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

namespace Android.Net.Http
{
    #region DnsOptions
    public partial class DnsOptions
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/DnsOptions.html#DNS_OPTION_DISABLED"/>
        /// </summary>
        public static int DNS_OPTION_DISABLED { get { if (!_DNS_OPTION_DISABLEDReady) { _DNS_OPTION_DISABLEDContent = SGetField<int>(LocalBridgeClazz, "DNS_OPTION_DISABLED"); _DNS_OPTION_DISABLEDReady = true; } return _DNS_OPTION_DISABLEDContent; } }
        private static int _DNS_OPTION_DISABLEDContent = default;
        private static bool _DNS_OPTION_DISABLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/DnsOptions.html#DNS_OPTION_ENABLED"/>
        /// </summary>
        public static int DNS_OPTION_ENABLED { get { if (!_DNS_OPTION_ENABLEDReady) { _DNS_OPTION_ENABLEDContent = SGetField<int>(LocalBridgeClazz, "DNS_OPTION_ENABLED"); _DNS_OPTION_ENABLEDReady = true; } return _DNS_OPTION_ENABLEDContent; } }
        private static int _DNS_OPTION_ENABLEDContent = default;
        private static bool _DNS_OPTION_ENABLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/DnsOptions.html#DNS_OPTION_UNSPECIFIED"/>
        /// </summary>
        public static int DNS_OPTION_UNSPECIFIED { get { if (!_DNS_OPTION_UNSPECIFIEDReady) { _DNS_OPTION_UNSPECIFIEDContent = SGetField<int>(LocalBridgeClazz, "DNS_OPTION_UNSPECIFIED"); _DNS_OPTION_UNSPECIFIEDReady = true; } return _DNS_OPTION_UNSPECIFIEDContent; } }
        private static int _DNS_OPTION_UNSPECIFIEDContent = default;
        private static bool _DNS_OPTION_UNSPECIFIEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/DnsOptions.html#getStaleDnsOptions()"/> 
        /// </summary>
        public Android.Net.Http.DnsOptions.StaleDnsOptions GetStaleDnsOptions
        {
            get { return IExecuteWithSignature<Android.Net.Http.DnsOptions.StaleDnsOptions>("getStaleDnsOptions", "()Landroid/net/http/DnsOptions$StaleDnsOptions;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/DnsOptions.html#getPersistHostCache()"/> 
        /// </summary>
        public int PersistHostCache
        {
            get { return IExecuteWithSignature<int>("getPersistHostCache", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/DnsOptions.html#getPersistHostCachePeriod()"/> 
        /// </summary>
        public Java.Time.Duration PersistHostCachePeriod
        {
            get { return IExecuteWithSignature<Java.Time.Duration>("getPersistHostCachePeriod", "()Ljava/time/Duration;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/DnsOptions.html#getPreestablishConnectionsToStaleDnsResults()"/> 
        /// </summary>
        public int PreestablishConnectionsToStaleDnsResults
        {
            get { return IExecuteWithSignature<int>("getPreestablishConnectionsToStaleDnsResults", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/DnsOptions.html#getStaleDns()"/> 
        /// </summary>
        public int StaleDns
        {
            get { return IExecuteWithSignature<int>("getStaleDns", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/DnsOptions.html#getUseHttpStackDnsResolver()"/> 
        /// </summary>
        public int UseHttpStackDnsResolver
        {
            get { return IExecuteWithSignature<int>("getUseHttpStackDnsResolver", "()I"); }
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
            /// <see href="https://developer.android.com/reference/android/net/http/DnsOptions.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Net.Http.DnsOptions"/></returns>
            public Android.Net.Http.DnsOptions Build()
            {
                return IExecuteWithSignature<Android.Net.Http.DnsOptions>("build", "()Landroid/net/http/DnsOptions;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/http/DnsOptions.Builder.html#setPersistHostCache(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Http.DnsOptions.Builder"/></returns>
            public Android.Net.Http.DnsOptions.Builder SetPersistHostCache(int arg0)
            {
                return IExecuteWithSignature<Android.Net.Http.DnsOptions.Builder>("setPersistHostCache", "(I)Landroid/net/http/DnsOptions$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/http/DnsOptions.Builder.html#setPersistHostCachePeriod(java.time.Duration)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Time.Duration"/></param>
            /// <returns><see cref="Android.Net.Http.DnsOptions.Builder"/></returns>
            public Android.Net.Http.DnsOptions.Builder SetPersistHostCachePeriod(Java.Time.Duration arg0)
            {
                return IExecuteWithSignature<Android.Net.Http.DnsOptions.Builder>("setPersistHostCachePeriod", "(Ljava/time/Duration;)Landroid/net/http/DnsOptions$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/http/DnsOptions.Builder.html#setPreestablishConnectionsToStaleDnsResults(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Http.DnsOptions.Builder"/></returns>
            public Android.Net.Http.DnsOptions.Builder SetPreestablishConnectionsToStaleDnsResults(int arg0)
            {
                return IExecuteWithSignature<Android.Net.Http.DnsOptions.Builder>("setPreestablishConnectionsToStaleDnsResults", "(I)Landroid/net/http/DnsOptions$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/http/DnsOptions.Builder.html#setStaleDns(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Http.DnsOptions.Builder"/></returns>
            public Android.Net.Http.DnsOptions.Builder SetStaleDns(int arg0)
            {
                return IExecuteWithSignature<Android.Net.Http.DnsOptions.Builder>("setStaleDns", "(I)Landroid/net/http/DnsOptions$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/http/DnsOptions.Builder.html#setStaleDnsOptions(android.net.http.DnsOptions.StaleDnsOptions)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Http.DnsOptions.StaleDnsOptions"/></param>
            /// <returns><see cref="Android.Net.Http.DnsOptions.Builder"/></returns>
            public Android.Net.Http.DnsOptions.Builder SetStaleDnsOptions(Android.Net.Http.DnsOptions.StaleDnsOptions arg0)
            {
                return IExecuteWithSignature<Android.Net.Http.DnsOptions.Builder>("setStaleDnsOptions", "(Landroid/net/http/DnsOptions$StaleDnsOptions;)Landroid/net/http/DnsOptions$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/http/DnsOptions.Builder.html#setUseHttpStackDnsResolver(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Http.DnsOptions.Builder"/></returns>
            public Android.Net.Http.DnsOptions.Builder SetUseHttpStackDnsResolver(int arg0)
            {
                return IExecuteWithSignature<Android.Net.Http.DnsOptions.Builder>("setUseHttpStackDnsResolver", "(I)Landroid/net/http/DnsOptions$Builder;", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region StaleDnsOptions
        public partial class StaleDnsOptions
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
            /// <see href="https://developer.android.com/reference/android/net/http/DnsOptions.StaleDnsOptions.html#getAllowCrossNetworkUsage()"/> 
            /// </summary>
            public int AllowCrossNetworkUsage
            {
                get { return IExecuteWithSignature<int>("getAllowCrossNetworkUsage", "()I"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/http/DnsOptions.StaleDnsOptions.html#getFreshLookupTimeout()"/> 
            /// </summary>
            public Java.Time.Duration FreshLookupTimeout
            {
                get { return IExecuteWithSignature<Java.Time.Duration>("getFreshLookupTimeout", "()Ljava/time/Duration;"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/http/DnsOptions.StaleDnsOptions.html#getMaxExpiredDelay()"/> 
            /// </summary>
            public Java.Time.Duration MaxExpiredDelay
            {
                get { return IExecuteWithSignature<Java.Time.Duration>("getMaxExpiredDelay", "()Ljava/time/Duration;"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/http/DnsOptions.StaleDnsOptions.html#getUseStaleOnNameNotResolved()"/> 
            /// </summary>
            public int UseStaleOnNameNotResolved
            {
                get { return IExecuteWithSignature<int>("getUseStaleOnNameNotResolved", "()I"); }
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
                /// <see href="https://developer.android.com/reference/android/net/http/DnsOptions.StaleDnsOptions.Builder.html#build()"/>
                /// </summary>
                /// <returns><see cref="Android.Net.Http.DnsOptions.StaleDnsOptions"/></returns>
                public Android.Net.Http.DnsOptions.StaleDnsOptions Build()
                {
                    return IExecuteWithSignature<Android.Net.Http.DnsOptions.StaleDnsOptions>("build", "()Landroid/net/http/DnsOptions$StaleDnsOptions;");
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/net/http/DnsOptions.StaleDnsOptions.Builder.html#setAllowCrossNetworkUsage(int)"/>
                /// </summary>
                /// <param name="arg0"><see cref="int"/></param>
                /// <returns><see cref="Android.Net.Http.DnsOptions.StaleDnsOptions.Builder"/></returns>
                public Android.Net.Http.DnsOptions.StaleDnsOptions.Builder SetAllowCrossNetworkUsage(int arg0)
                {
                    return IExecuteWithSignature<Android.Net.Http.DnsOptions.StaleDnsOptions.Builder>("setAllowCrossNetworkUsage", "(I)Landroid/net/http/DnsOptions$StaleDnsOptions$Builder;", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/net/http/DnsOptions.StaleDnsOptions.Builder.html#setFreshLookupTimeout(java.time.Duration)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Java.Time.Duration"/></param>
                /// <returns><see cref="Android.Net.Http.DnsOptions.StaleDnsOptions.Builder"/></returns>
                public Android.Net.Http.DnsOptions.StaleDnsOptions.Builder SetFreshLookupTimeout(Java.Time.Duration arg0)
                {
                    return IExecuteWithSignature<Android.Net.Http.DnsOptions.StaleDnsOptions.Builder>("setFreshLookupTimeout", "(Ljava/time/Duration;)Landroid/net/http/DnsOptions$StaleDnsOptions$Builder;", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/net/http/DnsOptions.StaleDnsOptions.Builder.html#setMaxExpiredDelay(java.time.Duration)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Java.Time.Duration"/></param>
                /// <returns><see cref="Android.Net.Http.DnsOptions.StaleDnsOptions.Builder"/></returns>
                public Android.Net.Http.DnsOptions.StaleDnsOptions.Builder SetMaxExpiredDelay(Java.Time.Duration arg0)
                {
                    return IExecuteWithSignature<Android.Net.Http.DnsOptions.StaleDnsOptions.Builder>("setMaxExpiredDelay", "(Ljava/time/Duration;)Landroid/net/http/DnsOptions$StaleDnsOptions$Builder;", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/net/http/DnsOptions.StaleDnsOptions.Builder.html#setUseStaleOnNameNotResolved(int)"/>
                /// </summary>
                /// <param name="arg0"><see cref="int"/></param>
                /// <returns><see cref="Android.Net.Http.DnsOptions.StaleDnsOptions.Builder"/></returns>
                public Android.Net.Http.DnsOptions.StaleDnsOptions.Builder SetUseStaleOnNameNotResolved(int arg0)
                {
                    return IExecuteWithSignature<Android.Net.Http.DnsOptions.StaleDnsOptions.Builder>("setUseStaleOnNameNotResolved", "(I)Landroid/net/http/DnsOptions$StaleDnsOptions$Builder;", arg0);
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

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}