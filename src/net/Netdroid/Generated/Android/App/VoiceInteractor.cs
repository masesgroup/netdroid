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

namespace Android.App
{
    #region VoiceInteractor
    public partial class VoiceInteractor
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/VoiceInteractor.html#getActiveRequest(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.App.VoiceInteractor.Request"/></returns>
        public Android.App.VoiceInteractor.Request GetActiveRequest(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Android.App.VoiceInteractor.Request>("getActiveRequest", "(Ljava/lang/String;)Landroid/app/VoiceInteractor$Request;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/VoiceInteractor.html#getActiveRequests()"/>
        /// </summary>
        /// <returns><see cref="Android.App.VoiceInteractor.Request"/></returns>
        public Android.App.VoiceInteractor.Request[] GetActiveRequests()
        {
            return IExecuteWithSignatureArray<Android.App.VoiceInteractor.Request>("getActiveRequests", "()[Landroid/app/VoiceInteractor$Request;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/VoiceInteractor.html#isDestroyed()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDestroyed()
        {
            return IExecuteWithSignature<bool>("isDestroyed", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/VoiceInteractor.html#registerOnDestroyedCallback(java.util.concurrent.Executor,java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Runnable"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RegisterOnDestroyedCallback(Java.Util.Concurrent.Executor arg0, Java.Lang.Runnable arg1)
        {
            return IExecute<bool>("registerOnDestroyedCallback", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/VoiceInteractor.html#submitRequest(android.app.VoiceInteractor.Request,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.VoiceInteractor.Request"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SubmitRequest(Android.App.VoiceInteractor.Request arg0, Java.Lang.String arg1)
        {
            return IExecute<bool>("submitRequest", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/VoiceInteractor.html#submitRequest(android.app.VoiceInteractor.Request)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.VoiceInteractor.Request"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SubmitRequest(Android.App.VoiceInteractor.Request arg0)
        {
            return IExecuteWithSignature<bool>("submitRequest", "(Landroid/app/VoiceInteractor$Request;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/VoiceInteractor.html#unregisterOnDestroyedCallback(java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool UnregisterOnDestroyedCallback(Java.Lang.Runnable arg0)
        {
            return IExecuteWithSignature<bool>("unregisterOnDestroyedCallback", "(Ljava/lang/Runnable;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/VoiceInteractor.html#supportsCommands(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool[] SupportsCommands(Java.Lang.String[] arg0)
        {
            return IExecuteWithSignatureArray<bool>("supportsCommands", "([Ljava/lang/String;)[Z", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/VoiceInteractor.html#getPackageName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetPackageName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getPackageName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/VoiceInteractor.html#notifyDirectActionsChanged()"/>
        /// </summary>
        public void NotifyDirectActionsChanged()
        {
            IExecuteWithSignature("notifyDirectActionsChanged", "()V");
        }

        #endregion

        #region Nested classes
        #region AbortVoiceRequest
        public partial class AbortVoiceRequest
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/VoiceInteractor.AbortVoiceRequest.html#%3Cinit%3E(android.app.VoiceInteractor.Prompt,android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.VoiceInteractor.Prompt"/></param>
            /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
            public AbortVoiceRequest(Android.App.VoiceInteractor.Prompt arg0, Android.Os.Bundle arg1)
                : base(arg0, arg1)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/VoiceInteractor.AbortVoiceRequest.html#onAbortResult(android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
            public void OnAbortResult(Android.Os.Bundle arg0)
            {
                IExecuteWithSignature("onAbortResult", "(Landroid/os/Bundle;)V", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region CommandRequest
        public partial class CommandRequest
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/VoiceInteractor.CommandRequest.html#%3Cinit%3E(java.lang.String,android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
            public CommandRequest(Java.Lang.String arg0, Android.Os.Bundle arg1)
                : base(arg0, arg1)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/VoiceInteractor.CommandRequest.html#onCommandResult(boolean,android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
            public void OnCommandResult(bool arg0, Android.Os.Bundle arg1)
            {
                IExecute("onCommandResult", arg0, arg1);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region CompleteVoiceRequest
        public partial class CompleteVoiceRequest
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/VoiceInteractor.CompleteVoiceRequest.html#%3Cinit%3E(android.app.VoiceInteractor.Prompt,android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.VoiceInteractor.Prompt"/></param>
            /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
            public CompleteVoiceRequest(Android.App.VoiceInteractor.Prompt arg0, Android.Os.Bundle arg1)
                : base(arg0, arg1)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/VoiceInteractor.CompleteVoiceRequest.html#onCompleteResult(android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
            public void OnCompleteResult(Android.Os.Bundle arg0)
            {
                IExecuteWithSignature("onCompleteResult", "(Landroid/os/Bundle;)V", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region ConfirmationRequest
        public partial class ConfirmationRequest
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/VoiceInteractor.ConfirmationRequest.html#%3Cinit%3E(android.app.VoiceInteractor.Prompt,android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.VoiceInteractor.Prompt"/></param>
            /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
            public ConfirmationRequest(Android.App.VoiceInteractor.Prompt arg0, Android.Os.Bundle arg1)
                : base(arg0, arg1)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/VoiceInteractor.ConfirmationRequest.html#onConfirmationResult(boolean,android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
            public void OnConfirmationResult(bool arg0, Android.Os.Bundle arg1)
            {
                IExecute("onConfirmationResult", arg0, arg1);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region PickOptionRequest
        public partial class PickOptionRequest
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/VoiceInteractor.PickOptionRequest.html#%3Cinit%3E(android.app.VoiceInteractor.Prompt,android.app.VoiceInteractor.PickOptionRequest.Option[],android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.VoiceInteractor.Prompt"/></param>
            /// <param name="arg1"><see cref="Android.App.VoiceInteractor.PickOptionRequest.Option"/></param>
            /// <param name="arg2"><see cref="Android.Os.Bundle"/></param>
            public PickOptionRequest(Android.App.VoiceInteractor.Prompt arg0, Android.App.VoiceInteractor.PickOptionRequest.Option[] arg1, Android.Os.Bundle arg2)
                : base(arg0, arg1, arg2)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/VoiceInteractor.PickOptionRequest.html#onPickOptionResult(boolean,android.app.VoiceInteractor.PickOptionRequest.Option[],android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <param name="arg1"><see cref="Android.App.VoiceInteractor.PickOptionRequest.Option"/></param>
            /// <param name="arg2"><see cref="Android.Os.Bundle"/></param>
            public void OnPickOptionResult(bool arg0, Android.App.VoiceInteractor.PickOptionRequest.Option[] arg1, Android.Os.Bundle arg2)
            {
                IExecute("onPickOptionResult", arg0, arg1, arg2);
            }

            #endregion

            #region Nested classes
            #region Option
            public partial class Option
            {
                #region Constructors
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/app/VoiceInteractor.PickOptionRequest.Option.html#%3Cinit%3E(java.lang.CharSequence,int)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
                /// <param name="arg1"><see cref="int"/></param>
                public Option(Java.Lang.CharSequence arg0, int arg1)
                    : base(arg0, arg1)
                {
                }

                #endregion

                #region Class/Interface conversion operators

                #endregion

                #region Fields
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/app/VoiceInteractor.PickOptionRequest.Option.html#CREATOR"/>
                /// </summary>
                public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
                private static Android.Os.Parcelable.Creator _CREATORContent = default;
                private static bool _CREATORReady = false; // this is used because in case of generics 

                #endregion

                #region Static methods

                #endregion

                #region Instance methods
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/app/VoiceInteractor.PickOptionRequest.Option.html#addSynonym(java.lang.CharSequence)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
                /// <returns><see cref="Android.App.VoiceInteractor.PickOptionRequest.Option"/></returns>
                public Android.App.VoiceInteractor.PickOptionRequest.Option AddSynonym(Java.Lang.CharSequence arg0)
                {
                    return IExecuteWithSignature<Android.App.VoiceInteractor.PickOptionRequest.Option>("addSynonym", "(Ljava/lang/CharSequence;)Landroid/app/VoiceInteractor$PickOptionRequest$Option;", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/app/VoiceInteractor.PickOptionRequest.Option.html#getExtras()"/>
                /// </summary>
                /// <returns><see cref="Android.Os.Bundle"/></returns>
                public Android.Os.Bundle GetExtras()
                {
                    return IExecuteWithSignature<Android.Os.Bundle>("getExtras", "()Landroid/os/Bundle;");
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/app/VoiceInteractor.PickOptionRequest.Option.html#countSynonyms()"/>
                /// </summary>
                /// <returns><see cref="int"/></returns>
                public int CountSynonyms()
                {
                    return IExecuteWithSignature<int>("countSynonyms", "()I");
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/app/VoiceInteractor.PickOptionRequest.Option.html#describeContents()"/>
                /// </summary>
                /// <returns><see cref="int"/></returns>
                public int DescribeContents()
                {
                    return IExecuteWithSignature<int>("describeContents", "()I");
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/app/VoiceInteractor.PickOptionRequest.Option.html#getIndex()"/>
                /// </summary>
                /// <returns><see cref="int"/></returns>
                public int GetIndex()
                {
                    return IExecuteWithSignature<int>("getIndex", "()I");
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/app/VoiceInteractor.PickOptionRequest.Option.html#getLabel()"/>
                /// </summary>
                /// <returns><see cref="Java.Lang.CharSequence"/></returns>
                public Java.Lang.CharSequence GetLabel()
                {
                    return IExecuteWithSignature<Java.Lang.CharSequence>("getLabel", "()Ljava/lang/CharSequence;");
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/app/VoiceInteractor.PickOptionRequest.Option.html#getSynonymAt(int)"/>
                /// </summary>
                /// <param name="arg0"><see cref="int"/></param>
                /// <returns><see cref="Java.Lang.CharSequence"/></returns>
                public Java.Lang.CharSequence GetSynonymAt(int arg0)
                {
                    return IExecuteWithSignature<Java.Lang.CharSequence>("getSynonymAt", "(I)Ljava/lang/CharSequence;", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/app/VoiceInteractor.PickOptionRequest.Option.html#setExtras(android.os.Bundle)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
                public void SetExtras(Android.Os.Bundle arg0)
                {
                    IExecuteWithSignature("setExtras", "(Landroid/os/Bundle;)V", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/app/VoiceInteractor.PickOptionRequest.Option.html#writeToParcel(android.os.Parcel,int)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
                /// <param name="arg1"><see cref="int"/></param>
                public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
                {
                    IExecute("writeToParcel", arg0, arg1);
                }

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

        #region Prompt
        public partial class Prompt
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/VoiceInteractor.Prompt.html#%3Cinit%3E(java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            public Prompt(Java.Lang.CharSequence arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/VoiceInteractor.Prompt.html#%3Cinit%3E(java.lang.CharSequence[],java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
            public Prompt(Java.Lang.CharSequence[] arg0, Java.Lang.CharSequence arg1)
                : base(arg0, arg1)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/VoiceInteractor.Prompt.html#CREATOR"/>
            /// </summary>
            public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
            private static Android.Os.Parcelable.Creator _CREATORContent = default;
            private static bool _CREATORReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/VoiceInteractor.Prompt.html#countVoicePrompts()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int CountVoicePrompts()
            {
                return IExecuteWithSignature<int>("countVoicePrompts", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/VoiceInteractor.Prompt.html#describeContents()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int DescribeContents()
            {
                return IExecuteWithSignature<int>("describeContents", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/VoiceInteractor.Prompt.html#getVisualPrompt()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.CharSequence"/></returns>
            public Java.Lang.CharSequence GetVisualPrompt()
            {
                return IExecuteWithSignature<Java.Lang.CharSequence>("getVisualPrompt", "()Ljava/lang/CharSequence;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/VoiceInteractor.Prompt.html#getVoicePromptAt(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Java.Lang.CharSequence"/></returns>
            public Java.Lang.CharSequence GetVoicePromptAt(int arg0)
            {
                return IExecuteWithSignature<Java.Lang.CharSequence>("getVoicePromptAt", "(I)Ljava/lang/CharSequence;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/VoiceInteractor.Prompt.html#writeToParcel(android.os.Parcel,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
            {
                IExecute("writeToParcel", arg0, arg1);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Request
        public partial class Request
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/VoiceInteractor.Request.html#getActivity()"/>
            /// </summary>
            /// <returns><see cref="Android.App.Activity"/></returns>
            public Android.App.Activity GetActivity()
            {
                return IExecuteWithSignature<Android.App.Activity>("getActivity", "()Landroid/app/Activity;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/VoiceInteractor.Request.html#getContext()"/>
            /// </summary>
            /// <returns><see cref="Android.Content.Context"/></returns>
            public Android.Content.Context GetContext()
            {
                return IExecuteWithSignature<Android.Content.Context>("getContext", "()Landroid/content/Context;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/VoiceInteractor.Request.html#getName()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetName()
            {
                return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/VoiceInteractor.Request.html#cancel()"/>
            /// </summary>
            public void Cancel()
            {
                IExecuteWithSignature("cancel", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/VoiceInteractor.Request.html#onAttached(android.app.Activity)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.Activity"/></param>
            public void OnAttached(Android.App.Activity arg0)
            {
                IExecuteWithSignature("onAttached", "(Landroid/app/Activity;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/VoiceInteractor.Request.html#onCancel()"/>
            /// </summary>
            public void OnCancel()
            {
                IExecuteWithSignature("onCancel", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/VoiceInteractor.Request.html#onDetached()"/>
            /// </summary>
            public void OnDetached()
            {
                IExecuteWithSignature("onDetached", "()V");
            }

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