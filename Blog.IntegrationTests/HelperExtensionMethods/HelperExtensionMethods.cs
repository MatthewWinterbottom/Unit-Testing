using System;

namespace Blog.IntegrationTests.HelperExtensionMethods
{
    public static class HelperExtensionMethods
    {
        public static string TrimControllerSuffix(this string fullControllerName)
        {
            bool stringEligibleForTrim =
                !string.IsNullOrEmpty(fullControllerName) && fullControllerName.EndsWith("Controller", StringComparison.OrdinalIgnoreCase);

            if (stringEligibleForTrim)
                return fullControllerName.Replace("Controller", string.Empty, StringComparison.OrdinalIgnoreCase);
            else
                return fullControllerName;
        }
    }
}
