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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Inputmethodservice
{
    #region Keyboard
    public partial class Keyboard
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.html#%3Cinit%3E(android.content.Context,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        [global::System.Obsolete()]
        public Keyboard(Android.Content.Context arg0, int arg1, int arg2, int arg3, int arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.html#%3Cinit%3E(android.content.Context,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        [global::System.Obsolete()]
        public Keyboard(Android.Content.Context arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.html#%3Cinit%3E(android.content.Context,int,java.lang.CharSequence,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        [global::System.Obsolete()]
        public Keyboard(Android.Content.Context arg0, int arg1, Java.Lang.CharSequence arg2, int arg3, int arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.html#%3Cinit%3E(android.content.Context,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        [global::System.Obsolete()]
        public Keyboard(Android.Content.Context arg0, int arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.html#EDGE_BOTTOM"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int EDGE_BOTTOM { get { if (!_EDGE_BOTTOMReady) { _EDGE_BOTTOMContent = SGetField<int>(LocalBridgeClazz, "EDGE_BOTTOM"); _EDGE_BOTTOMReady = true; } return _EDGE_BOTTOMContent; } }
        private static int _EDGE_BOTTOMContent = default;
        private static bool _EDGE_BOTTOMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.html#EDGE_LEFT"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int EDGE_LEFT { get { if (!_EDGE_LEFTReady) { _EDGE_LEFTContent = SGetField<int>(LocalBridgeClazz, "EDGE_LEFT"); _EDGE_LEFTReady = true; } return _EDGE_LEFTContent; } }
        private static int _EDGE_LEFTContent = default;
        private static bool _EDGE_LEFTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.html#EDGE_RIGHT"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int EDGE_RIGHT { get { if (!_EDGE_RIGHTReady) { _EDGE_RIGHTContent = SGetField<int>(LocalBridgeClazz, "EDGE_RIGHT"); _EDGE_RIGHTReady = true; } return _EDGE_RIGHTContent; } }
        private static int _EDGE_RIGHTContent = default;
        private static bool _EDGE_RIGHTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.html#EDGE_TOP"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int EDGE_TOP { get { if (!_EDGE_TOPReady) { _EDGE_TOPContent = SGetField<int>(LocalBridgeClazz, "EDGE_TOP"); _EDGE_TOPReady = true; } return _EDGE_TOPContent; } }
        private static int _EDGE_TOPContent = default;
        private static bool _EDGE_TOPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.html#KEYCODE_ALT"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int KEYCODE_ALT { get { if (!_KEYCODE_ALTReady) { _KEYCODE_ALTContent = SGetField<int>(LocalBridgeClazz, "KEYCODE_ALT"); _KEYCODE_ALTReady = true; } return _KEYCODE_ALTContent; } }
        private static int _KEYCODE_ALTContent = default;
        private static bool _KEYCODE_ALTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.html#KEYCODE_CANCEL"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int KEYCODE_CANCEL { get { if (!_KEYCODE_CANCELReady) { _KEYCODE_CANCELContent = SGetField<int>(LocalBridgeClazz, "KEYCODE_CANCEL"); _KEYCODE_CANCELReady = true; } return _KEYCODE_CANCELContent; } }
        private static int _KEYCODE_CANCELContent = default;
        private static bool _KEYCODE_CANCELReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.html#KEYCODE_DELETE"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int KEYCODE_DELETE { get { if (!_KEYCODE_DELETEReady) { _KEYCODE_DELETEContent = SGetField<int>(LocalBridgeClazz, "KEYCODE_DELETE"); _KEYCODE_DELETEReady = true; } return _KEYCODE_DELETEContent; } }
        private static int _KEYCODE_DELETEContent = default;
        private static bool _KEYCODE_DELETEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.html#KEYCODE_DONE"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int KEYCODE_DONE { get { if (!_KEYCODE_DONEReady) { _KEYCODE_DONEContent = SGetField<int>(LocalBridgeClazz, "KEYCODE_DONE"); _KEYCODE_DONEReady = true; } return _KEYCODE_DONEContent; } }
        private static int _KEYCODE_DONEContent = default;
        private static bool _KEYCODE_DONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.html#KEYCODE_MODE_CHANGE"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int KEYCODE_MODE_CHANGE { get { if (!_KEYCODE_MODE_CHANGEReady) { _KEYCODE_MODE_CHANGEContent = SGetField<int>(LocalBridgeClazz, "KEYCODE_MODE_CHANGE"); _KEYCODE_MODE_CHANGEReady = true; } return _KEYCODE_MODE_CHANGEContent; } }
        private static int _KEYCODE_MODE_CHANGEContent = default;
        private static bool _KEYCODE_MODE_CHANGEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.html#KEYCODE_SHIFT"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int KEYCODE_SHIFT { get { if (!_KEYCODE_SHIFTReady) { _KEYCODE_SHIFTContent = SGetField<int>(LocalBridgeClazz, "KEYCODE_SHIFT"); _KEYCODE_SHIFTReady = true; } return _KEYCODE_SHIFTContent; } }
        private static int _KEYCODE_SHIFTContent = default;
        private static bool _KEYCODE_SHIFTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.html#isShifted()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool IsShifted()
        {
            return IExecuteWithSignature<bool>("isShifted", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.html#setShifted(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool SetShifted(bool arg0)
        {
            return IExecuteWithSignature<bool>("setShifted", "(Z)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.html#getHeight()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetHeight()
        {
            return IExecuteWithSignature<int>("getHeight", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.html#getMinWidth()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetMinWidth()
        {
            return IExecuteWithSignature<int>("getMinWidth", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.html#getShiftKeyIndex()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetShiftKeyIndex()
        {
            return IExecuteWithSignature<int>("getShiftKeyIndex", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.html#getNearestKeys(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int[] GetNearestKeys(int arg0, int arg1)
        {
            return IExecuteArray<int>("getNearestKeys", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.html#getKeys()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        [global::System.Obsolete()]
        public Java.Util.List<Android.Inputmethodservice.Keyboard.Key> GetKeys()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Inputmethodservice.Keyboard.Key>>("getKeys", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.html#getModifierKeys()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        [global::System.Obsolete()]
        public Java.Util.List<Android.Inputmethodservice.Keyboard.Key> GetModifierKeys()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Inputmethodservice.Keyboard.Key>>("getModifierKeys", "()Ljava/util/List;");
        }

        #endregion

        #region Nested classes
        #region Key
        public partial class Key
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.Key.html#%3Cinit%3E(android.content.res.Resources,android.inputmethodservice.Keyboard.Row,int,int,android.content.res.XmlResourceParser)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.Res.Resources"/></param>
            /// <param name="arg1"><see cref="Android.Inputmethodservice.Keyboard.Row"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            /// <param name="arg4"><see cref="Android.Content.Res.XmlResourceParser"/></param>
            [global::System.Obsolete()]
            public Key(Android.Content.Res.Resources arg0, Android.Inputmethodservice.Keyboard.Row arg1, int arg2, int arg3, Android.Content.Res.XmlResourceParser arg4)
                : base(arg0, arg1, arg2, arg3, arg4)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.Key.html#%3Cinit%3E(android.inputmethodservice.Keyboard.Row)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Inputmethodservice.Keyboard.Row"/></param>
            [global::System.Obsolete()]
            public Key(Android.Inputmethodservice.Keyboard.Row arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.Key.html#icon"/>
            /// </summary>
            [global::System.Obsolete()]
            public Android.Graphics.Drawable.Drawable icon { get { return IGetField<Android.Graphics.Drawable.Drawable>("icon"); } set { ISetField("icon", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.Key.html#iconPreview"/>
            /// </summary>
            [global::System.Obsolete()]
            public Android.Graphics.Drawable.Drawable iconPreview { get { return IGetField<Android.Graphics.Drawable.Drawable>("iconPreview"); } set { ISetField("iconPreview", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.Key.html#modifier"/>
            /// </summary>
            [global::System.Obsolete()]
            public bool modifier { get { return IGetField<bool>("modifier"); } set { ISetField("modifier", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.Key.html#on"/>
            /// </summary>
            [global::System.Obsolete()]
            public bool on { get { return IGetField<bool>("on"); } set { ISetField("on", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.Key.html#pressed"/>
            /// </summary>
            [global::System.Obsolete()]
            public bool pressed { get { return IGetField<bool>("pressed"); } set { ISetField("pressed", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.Key.html#repeatable"/>
            /// </summary>
            [global::System.Obsolete()]
            public bool repeatable { get { return IGetField<bool>("repeatable"); } set { ISetField("repeatable", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.Key.html#sticky"/>
            /// </summary>
            [global::System.Obsolete()]
            public bool sticky { get { return IGetField<bool>("sticky"); } set { ISetField("sticky", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.Key.html#edgeFlags"/>
            /// </summary>
            [global::System.Obsolete()]
            public int edgeFlags { get { return IGetField<int>("edgeFlags"); } set { ISetField("edgeFlags", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.Key.html#gap"/>
            /// </summary>
            [global::System.Obsolete()]
            public int gap { get { return IGetField<int>("gap"); } set { ISetField("gap", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.Key.html#height"/>
            /// </summary>
            [global::System.Obsolete()]
            public int height { get { return IGetField<int>("height"); } set { ISetField("height", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.Key.html#popupResId"/>
            /// </summary>
            [global::System.Obsolete()]
            public int popupResId { get { return IGetField<int>("popupResId"); } set { ISetField("popupResId", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.Key.html#width"/>
            /// </summary>
            [global::System.Obsolete()]
            public int width { get { return IGetField<int>("width"); } set { ISetField("width", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.Key.html#x"/>
            /// </summary>
            [global::System.Obsolete()]
            public int x { get { return IGetField<int>("x"); } set { ISetField("x", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.Key.html#y"/>
            /// </summary>
            [global::System.Obsolete()]
            public int y { get { return IGetField<int>("y"); } set { ISetField("y", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.Key.html#codes"/>
            /// </summary>
            [global::System.Obsolete()]
            public int[] codes { get { return IGetFieldArray<int>("codes"); } set { ISetField("codes", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.Key.html#label"/>
            /// </summary>
            [global::System.Obsolete()]
            public Java.Lang.CharSequence label { get { return IGetField<Java.Lang.CharSequence>("label"); } set { ISetField("label", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.Key.html#popupCharacters"/>
            /// </summary>
            [global::System.Obsolete()]
            public Java.Lang.CharSequence popupCharacters { get { return IGetField<Java.Lang.CharSequence>("popupCharacters"); } set { ISetField("popupCharacters", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.Key.html#text"/>
            /// </summary>
            [global::System.Obsolete()]
            public Java.Lang.CharSequence text { get { return IGetField<Java.Lang.CharSequence>("text"); } set { ISetField("text", value); } }

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.Key.html#isInside(int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <returns><see cref="bool"/></returns>
            [global::System.Obsolete()]
            public bool IsInside(int arg0, int arg1)
            {
                return IExecute<bool>("isInside", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.Key.html#squaredDistanceFrom(int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <returns><see cref="int"/></returns>
            [global::System.Obsolete()]
            public int SquaredDistanceFrom(int arg0, int arg1)
            {
                return IExecute<int>("squaredDistanceFrom", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.Key.html#getCurrentDrawableState()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            [global::System.Obsolete()]
            public int[] GetCurrentDrawableState()
            {
                return IExecuteWithSignatureArray<int>("getCurrentDrawableState", "()[I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.Key.html#onPressed()"/>
            /// </summary>
            [global::System.Obsolete()]
            public void OnPressed()
            {
                IExecuteWithSignature("onPressed", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.Key.html#onReleased(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            [global::System.Obsolete()]
            public void OnReleased(bool arg0)
            {
                IExecuteWithSignature("onReleased", "(Z)V", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Row
        public partial class Row
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.Row.html#%3Cinit%3E(android.content.res.Resources,android.inputmethodservice.Keyboard,android.content.res.XmlResourceParser)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.Res.Resources"/></param>
            /// <param name="arg1"><see cref="Android.Inputmethodservice.Keyboard"/></param>
            /// <param name="arg2"><see cref="Android.Content.Res.XmlResourceParser"/></param>
            [global::System.Obsolete()]
            public Row(Android.Content.Res.Resources arg0, Android.Inputmethodservice.Keyboard arg1, Android.Content.Res.XmlResourceParser arg2)
                : base(arg0, arg1, arg2)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.Row.html#%3Cinit%3E(android.inputmethodservice.Keyboard)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Inputmethodservice.Keyboard"/></param>
            [global::System.Obsolete()]
            public Row(Android.Inputmethodservice.Keyboard arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.Row.html#defaultHeight"/>
            /// </summary>
            [global::System.Obsolete()]
            public int defaultHeight { get { return IGetField<int>("defaultHeight"); } set { ISetField("defaultHeight", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.Row.html#defaultHorizontalGap"/>
            /// </summary>
            [global::System.Obsolete()]
            public int defaultHorizontalGap { get { return IGetField<int>("defaultHorizontalGap"); } set { ISetField("defaultHorizontalGap", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.Row.html#defaultWidth"/>
            /// </summary>
            [global::System.Obsolete()]
            public int defaultWidth { get { return IGetField<int>("defaultWidth"); } set { ISetField("defaultWidth", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.Row.html#mode"/>
            /// </summary>
            [global::System.Obsolete()]
            public int mode { get { return IGetField<int>("mode"); } set { ISetField("mode", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.Row.html#rowEdgeFlags"/>
            /// </summary>
            [global::System.Obsolete()]
            public int rowEdgeFlags { get { return IGetField<int>("rowEdgeFlags"); } set { ISetField("rowEdgeFlags", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/Keyboard.Row.html#verticalGap"/>
            /// </summary>
            [global::System.Obsolete()]
            public int verticalGap { get { return IGetField<int>("verticalGap"); } set { ISetField("verticalGap", value); } }

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}