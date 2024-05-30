/*
*  Copyright 2024 MASES s.r.l.
*
*  Licensed under the Apache License, Version 2.0 (the "License");
*  you may not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
*  http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing, software
*  distributed under the License is distributed on an "AS IS" BASIS,
*  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
*  See the License for the specific language governing permissions and
*  limitations under the License.
*
*  Refer to LICENSE for more information.
*/

/*
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Content.Pm
{
    #region ComponentInfo
    public partial class ComponentInfo
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ComponentInfo.html#%3Cinit%3E(android.content.pm.ComponentInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Pm.ComponentInfo"/></param>
        public ComponentInfo(Android.Content.Pm.ComponentInfo arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ComponentInfo.html#applicationInfo"/>
        /// </summary>
        public Android.Content.Pm.ApplicationInfo applicationInfo { get { return IGetField<Android.Content.Pm.ApplicationInfo>("applicationInfo"); } set { ISetField("applicationInfo", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ComponentInfo.html#directBootAware"/>
        /// </summary>
        public bool directBootAware { get { return IGetField<bool>("directBootAware"); } set { ISetField("directBootAware", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ComponentInfo.html#enabled"/>
        /// </summary>
        public bool enabled { get { return IGetField<bool>("enabled"); } set { ISetField("enabled", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ComponentInfo.html#exported"/>
        /// </summary>
        public bool exported { get { return IGetField<bool>("exported"); } set { ISetField("exported", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ComponentInfo.html#descriptionRes"/>
        /// </summary>
        public int descriptionRes { get { return IGetField<int>("descriptionRes"); } set { ISetField("descriptionRes", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ComponentInfo.html#processName"/>
        /// </summary>
        public Java.Lang.String processName { get { return IGetField<Java.Lang.String>("processName"); } set { ISetField("processName", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ComponentInfo.html#splitName"/>
        /// </summary>
        public Java.Lang.String splitName { get { return IGetField<Java.Lang.String>("splitName"); } set { ISetField("splitName", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ComponentInfo.html#attributionTags"/>
        /// </summary>
        public Java.Lang.String[] attributionTags { get { return IGetFieldArray<Java.Lang.String>("attributionTags"); } set { ISetField("attributionTags", value); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ComponentInfo.html#getBannerResource()"/> 
        /// </summary>
        public int BannerResource
        {
            get { return IExecuteWithSignature<int>("getBannerResource", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ComponentInfo.html#getIconResource()"/> 
        /// </summary>
        public int IconResource
        {
            get { return IExecuteWithSignature<int>("getIconResource", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ComponentInfo.html#getLogoResource()"/> 
        /// </summary>
        public int LogoResource
        {
            get { return IExecuteWithSignature<int>("getLogoResource", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ComponentInfo.html#isEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEnabled()
        {
            return IExecuteWithSignature<bool>("isEnabled", "()Z");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}