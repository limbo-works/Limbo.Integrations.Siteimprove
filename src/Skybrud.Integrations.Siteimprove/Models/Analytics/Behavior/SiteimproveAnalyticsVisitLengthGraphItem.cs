﻿using System;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Integrations.Siteimprove.Models.Analytics.Behavior {

    public class SiteimproveAnalyticsVisitLengthGraphItem : SiteimproveObject {

        #region Properties

        public DateTime Timestamp { get; private set; }

        public float VisitDurationAverageInMinutes { get; private set; }

        public TimeSpan VisitDurationAverage { get; private set; }

        #endregion

        #region Constructors

        private SiteimproveAnalyticsVisitLengthGraphItem(JObject obj) : base(obj) {
            Timestamp = obj.GetString("timestamp", DateTime.Parse);
            VisitDurationAverageInMinutes = obj.GetFloat("visit_duration_average_in_minutes");
            VisitDurationAverage = TimeSpan.FromMinutes(VisitDurationAverageInMinutes);
        }

        #endregion

        #region Static methods

        public static SiteimproveAnalyticsVisitLengthGraphItem Parse(JObject obj) {
            return obj == null ? null : new SiteimproveAnalyticsVisitLengthGraphItem(obj);
        }

        #endregion

    }

}