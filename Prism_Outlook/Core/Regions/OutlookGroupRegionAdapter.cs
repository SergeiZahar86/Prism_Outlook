﻿using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prism_Outlook.Core.Regions
{

    public class OutlookGroupRegionAdapter : RegionAdapterBase<XamOutlookBar>
    {
        public OutlookGroupRegionAdapter(IRegionBehaviorFactory factory)
            : base(factory)
        {

        }

        protected override void Adapt(IRegion region, XamOutlookBar regionTarget)
        {
            region.Views.CollectionChanged += ((x, y) =>
            {
                switch (y.Action)
                {
                    case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
                        {
                            foreach (OutlookBarGroup group in y.NewItems)
                            {
                                regionTarget.Groups.Add(group);

                                //The WPF XamOutlookBar does not automatically select the first group in it's collection.
                                //So we must manually select the group if it is the first one in the collection, but we don't
                                //want to excute this code every time a new group is added, only if the first group is the current group being added.
                                if (regionTarget.Groups[0] == group)
                                {
                                    regionTarget.SelectedGroup = group;
                                }
                            }
                            break;
                        }
                    case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
                        {
                            foreach (OutlookBarGroup group in y.OldItems)
                            {
                                regionTarget.Groups.Remove(group);
                            }
                            break;
                        }
                }
            });
        }

        protected override IRegion CreateRegion()
        {
            return new SingleActiveRegion();
        }
    }

}
