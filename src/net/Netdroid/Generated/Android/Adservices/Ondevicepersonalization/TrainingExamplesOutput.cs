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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Adservices.Ondevicepersonalization
{
    #region TrainingExamplesOutput
    public partial class TrainingExamplesOutput
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
        /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/TrainingExamplesOutput.html#getTrainingExampleRecords()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Adservices.Ondevicepersonalization.TrainingExampleRecord> GetTrainingExampleRecords()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Adservices.Ondevicepersonalization.TrainingExampleRecord>>("getTrainingExampleRecords", "()Ljava/util/List;");
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
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
            /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/TrainingExamplesOutput.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Adservices.Ondevicepersonalization.TrainingExamplesOutput"/></returns>
            public Android.Adservices.Ondevicepersonalization.TrainingExamplesOutput Build()
            {
                return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.TrainingExamplesOutput>("build", "()Landroid/adservices/ondevicepersonalization/TrainingExamplesOutput;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/TrainingExamplesOutput.Builder.html#addTrainingExampleRecord(android.adservices.ondevicepersonalization.TrainingExampleRecord)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Adservices.Ondevicepersonalization.TrainingExampleRecord"/></param>
            /// <returns><see cref="Android.Adservices.Ondevicepersonalization.TrainingExamplesOutput.Builder"/></returns>
            public Android.Adservices.Ondevicepersonalization.TrainingExamplesOutput.Builder AddTrainingExampleRecord(Android.Adservices.Ondevicepersonalization.TrainingExampleRecord arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.TrainingExamplesOutput.Builder>("addTrainingExampleRecord", "(Landroid/adservices/ondevicepersonalization/TrainingExampleRecord;)Landroid/adservices/ondevicepersonalization/TrainingExamplesOutput$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/TrainingExamplesOutput.Builder.html#setTrainingExampleRecords(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <returns><see cref="Android.Adservices.Ondevicepersonalization.TrainingExamplesOutput.Builder"/></returns>
            public Android.Adservices.Ondevicepersonalization.TrainingExamplesOutput.Builder SetTrainingExampleRecords(Java.Util.List<Android.Adservices.Ondevicepersonalization.TrainingExampleRecord> arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.TrainingExamplesOutput.Builder>("setTrainingExampleRecords", "(Ljava/util/List;)Landroid/adservices/ondevicepersonalization/TrainingExamplesOutput$Builder;", arg0);
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