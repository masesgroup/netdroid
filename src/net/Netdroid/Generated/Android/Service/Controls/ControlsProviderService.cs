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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Service.Controls
{
    #region ControlsProviderService
    public partial class ControlsProviderService
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/ControlsProviderService.html#CONTROLS_SURFACE_ACTIVITY_PANEL"/>
        /// </summary>
        public static int CONTROLS_SURFACE_ACTIVITY_PANEL { get { if (!_CONTROLS_SURFACE_ACTIVITY_PANELReady) { _CONTROLS_SURFACE_ACTIVITY_PANELContent = SGetField<int>(LocalBridgeClazz, "CONTROLS_SURFACE_ACTIVITY_PANEL"); _CONTROLS_SURFACE_ACTIVITY_PANELReady = true; } return _CONTROLS_SURFACE_ACTIVITY_PANELContent; } }
        private static int _CONTROLS_SURFACE_ACTIVITY_PANELContent = default;
        private static bool _CONTROLS_SURFACE_ACTIVITY_PANELReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/ControlsProviderService.html#CONTROLS_SURFACE_DREAM"/>
        /// </summary>
        public static int CONTROLS_SURFACE_DREAM { get { if (!_CONTROLS_SURFACE_DREAMReady) { _CONTROLS_SURFACE_DREAMContent = SGetField<int>(LocalBridgeClazz, "CONTROLS_SURFACE_DREAM"); _CONTROLS_SURFACE_DREAMReady = true; } return _CONTROLS_SURFACE_DREAMContent; } }
        private static int _CONTROLS_SURFACE_DREAMContent = default;
        private static bool _CONTROLS_SURFACE_DREAMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/ControlsProviderService.html#EXTRA_CONTROLS_SURFACE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_CONTROLS_SURFACE { get { if (!_EXTRA_CONTROLS_SURFACEReady) { _EXTRA_CONTROLS_SURFACEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_CONTROLS_SURFACE"); _EXTRA_CONTROLS_SURFACEReady = true; } return _EXTRA_CONTROLS_SURFACEContent; } }
        private static Java.Lang.String _EXTRA_CONTROLS_SURFACEContent = default;
        private static bool _EXTRA_CONTROLS_SURFACEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/ControlsProviderService.html#EXTRA_LOCKSCREEN_ALLOW_TRIVIAL_CONTROLS"/>
        /// </summary>
        public static Java.Lang.String EXTRA_LOCKSCREEN_ALLOW_TRIVIAL_CONTROLS { get { if (!_EXTRA_LOCKSCREEN_ALLOW_TRIVIAL_CONTROLSReady) { _EXTRA_LOCKSCREEN_ALLOW_TRIVIAL_CONTROLSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_LOCKSCREEN_ALLOW_TRIVIAL_CONTROLS"); _EXTRA_LOCKSCREEN_ALLOW_TRIVIAL_CONTROLSReady = true; } return _EXTRA_LOCKSCREEN_ALLOW_TRIVIAL_CONTROLSContent; } }
        private static Java.Lang.String _EXTRA_LOCKSCREEN_ALLOW_TRIVIAL_CONTROLSContent = default;
        private static bool _EXTRA_LOCKSCREEN_ALLOW_TRIVIAL_CONTROLSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/ControlsProviderService.html#META_DATA_PANEL_ACTIVITY"/>
        /// </summary>
        public static Java.Lang.String META_DATA_PANEL_ACTIVITY { get { if (!_META_DATA_PANEL_ACTIVITYReady) { _META_DATA_PANEL_ACTIVITYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "META_DATA_PANEL_ACTIVITY"); _META_DATA_PANEL_ACTIVITYReady = true; } return _META_DATA_PANEL_ACTIVITYContent; } }
        private static Java.Lang.String _META_DATA_PANEL_ACTIVITYContent = default;
        private static bool _META_DATA_PANEL_ACTIVITYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/ControlsProviderService.html#SERVICE_CONTROLS"/>
        /// </summary>
        public static Java.Lang.String SERVICE_CONTROLS { get { if (!_SERVICE_CONTROLSReady) { _SERVICE_CONTROLSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SERVICE_CONTROLS"); _SERVICE_CONTROLSReady = true; } return _SERVICE_CONTROLSContent; } }
        private static Java.Lang.String _SERVICE_CONTROLSContent = default;
        private static bool _SERVICE_CONTROLSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/ControlsProviderService.html#TAG"/>
        /// </summary>
        public static Java.Lang.String TAG { get { if (!_TAGReady) { _TAGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TAG"); _TAGReady = true; } return _TAGContent; } }
        private static Java.Lang.String _TAGContent = default;
        private static bool _TAGReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/ControlsProviderService.html#requestAddControl(android.content.Context,android.content.ComponentName,android.service.controls.Control)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Content.ComponentName"/></param>
        /// <param name="arg2"><see cref="Android.Service.Controls.Control"/></param>
        public static void RequestAddControl(Android.Content.Context arg0, Android.Content.ComponentName arg1, Android.Service.Controls.Control arg2)
        {
            SExecute(LocalBridgeClazz, "requestAddControl", arg0, arg1, arg2);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/ControlsProviderService.html#createPublisherFor(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Flow.Publisher"/></returns>
        public Java.Util.Concurrent.Flow.Publisher<Android.Service.Controls.Control> CreatePublisherFor(Java.Util.List<Java.Lang.String> arg0)
        {
            return IExecuteWithSignature<Java.Util.Concurrent.Flow.Publisher<Android.Service.Controls.Control>>("createPublisherFor", "(Ljava/util/List;)Ljava/util/concurrent/Flow$Publisher;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/ControlsProviderService.html#createPublisherForAllAvailable()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.Flow.Publisher"/></returns>
        public Java.Util.Concurrent.Flow.Publisher<Android.Service.Controls.Control> CreatePublisherForAllAvailable()
        {
            return IExecuteWithSignature<Java.Util.Concurrent.Flow.Publisher<Android.Service.Controls.Control>>("createPublisherForAllAvailable", "()Ljava/util/concurrent/Flow$Publisher;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/ControlsProviderService.html#performControlAction(java.lang.String,android.service.controls.actions.ControlAction,java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Service.Controls.Actions.ControlAction"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.Consumer"/></param>
        public void PerformControlAction(Java.Lang.String arg0, Android.Service.Controls.Actions.ControlAction arg1, Java.Util.Function.Consumer<Java.Lang.Integer> arg2)
        {
            IExecute("performControlAction", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/ControlsProviderService.html#createPublisherForSuggested()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.Flow.Publisher"/></returns>
        public Java.Util.Concurrent.Flow.Publisher<Android.Service.Controls.Control> CreatePublisherForSuggested()
        {
            return IExecuteWithSignature<Java.Util.Concurrent.Flow.Publisher<Android.Service.Controls.Control>>("createPublisherForSuggested", "()Ljava/util/concurrent/Flow$Publisher;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}