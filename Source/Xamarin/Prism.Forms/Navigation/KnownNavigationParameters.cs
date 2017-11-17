﻿namespace Prism.Navigation
{
    public static class KnownNavigationParameters
    {
        /// <summary>
        /// Used to dynamically create a Page that will be used as a Tab when navigating to a TabbedPage.
        /// </summary>
        public const string CreateTab = "createTab";

        /// <summary>
        /// Used to select an existing Tab when navigating to a Tabbedpage.
        /// </summary>
        public const string SelectedTab = "selectedTab";

        /// <summary>
        /// Used to control the navigation stack. If <c>true</c> uses PopModalAsync, if <c>false</c> uses PopAsync.
        /// </summary>
        public const string UseModalNavigation = "useModalNavigation";

        /// <summary>
        /// USed to control the navigation transition. If <c>true</c> the transition is animated, if <c>false</c> there is no animation on transition.
        /// </summary>
        public const string Animated = "animated";
    }
}
