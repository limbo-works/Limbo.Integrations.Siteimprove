using System;
using Skybrud.Social.Json;

namespace Skybrud.Siteimprove.Skybrud.Social {
    
    public static class SocialExtensionMethods {
        
        public static float GetFloat(this JsonObject obj, string name) {
            return obj.GetValue<float>(name);
        }

        public static float GetFloat(this JsonObject obj, string name, IFormatProvider provider) {
            return obj.GetValue<float>(name, provider);
        }

    }

}
