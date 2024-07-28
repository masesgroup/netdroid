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

namespace Android.System
{
    #region StructStatVfs
    public partial class StructStatVfs
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructStatVfs.html#%3Cinit%3E(long,long,long,long,long,long,long,long,long,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <param name="arg4"><see cref="long"/></param>
        /// <param name="arg5"><see cref="long"/></param>
        /// <param name="arg6"><see cref="long"/></param>
        /// <param name="arg7"><see cref="long"/></param>
        /// <param name="arg8"><see cref="long"/></param>
        /// <param name="arg9"><see cref="long"/></param>
        /// <param name="arg10"><see cref="long"/></param>
        public StructStatVfs(long arg0, long arg1, long arg2, long arg3, long arg4, long arg5, long arg6, long arg7, long arg8, long arg9, long arg10)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructStatVfs.html#f_bavail"/>
        /// </summary>
        public long f_bavail { get { if (!_f_bavailReady) { _f_bavailContent = IGetField<long>("f_bavail"); _f_bavailReady = true; } return _f_bavailContent; } }
        private long _f_bavailContent = default;
        private bool _f_bavailReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructStatVfs.html#f_bfree"/>
        /// </summary>
        public long f_bfree { get { if (!_f_bfreeReady) { _f_bfreeContent = IGetField<long>("f_bfree"); _f_bfreeReady = true; } return _f_bfreeContent; } }
        private long _f_bfreeContent = default;
        private bool _f_bfreeReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructStatVfs.html#f_blocks"/>
        /// </summary>
        public long f_blocks { get { if (!_f_blocksReady) { _f_blocksContent = IGetField<long>("f_blocks"); _f_blocksReady = true; } return _f_blocksContent; } }
        private long _f_blocksContent = default;
        private bool _f_blocksReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructStatVfs.html#f_bsize"/>
        /// </summary>
        public long f_bsize { get { if (!_f_bsizeReady) { _f_bsizeContent = IGetField<long>("f_bsize"); _f_bsizeReady = true; } return _f_bsizeContent; } }
        private long _f_bsizeContent = default;
        private bool _f_bsizeReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructStatVfs.html#f_favail"/>
        /// </summary>
        public long f_favail { get { if (!_f_favailReady) { _f_favailContent = IGetField<long>("f_favail"); _f_favailReady = true; } return _f_favailContent; } }
        private long _f_favailContent = default;
        private bool _f_favailReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructStatVfs.html#f_ffree"/>
        /// </summary>
        public long f_ffree { get { if (!_f_ffreeReady) { _f_ffreeContent = IGetField<long>("f_ffree"); _f_ffreeReady = true; } return _f_ffreeContent; } }
        private long _f_ffreeContent = default;
        private bool _f_ffreeReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructStatVfs.html#f_files"/>
        /// </summary>
        public long f_files { get { if (!_f_filesReady) { _f_filesContent = IGetField<long>("f_files"); _f_filesReady = true; } return _f_filesContent; } }
        private long _f_filesContent = default;
        private bool _f_filesReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructStatVfs.html#f_flag"/>
        /// </summary>
        public long f_flag { get { if (!_f_flagReady) { _f_flagContent = IGetField<long>("f_flag"); _f_flagReady = true; } return _f_flagContent; } }
        private long _f_flagContent = default;
        private bool _f_flagReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructStatVfs.html#f_frsize"/>
        /// </summary>
        public long f_frsize { get { if (!_f_frsizeReady) { _f_frsizeContent = IGetField<long>("f_frsize"); _f_frsizeReady = true; } return _f_frsizeContent; } }
        private long _f_frsizeContent = default;
        private bool _f_frsizeReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructStatVfs.html#f_fsid"/>
        /// </summary>
        public long f_fsid { get { if (!_f_fsidReady) { _f_fsidContent = IGetField<long>("f_fsid"); _f_fsidReady = true; } return _f_fsidContent; } }
        private long _f_fsidContent = default;
        private bool _f_fsidReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructStatVfs.html#f_namemax"/>
        /// </summary>
        public long f_namemax { get { if (!_f_namemaxReady) { _f_namemaxContent = IGetField<long>("f_namemax"); _f_namemaxReady = true; } return _f_namemaxContent; } }
        private long _f_namemaxContent = default;
        private bool _f_namemaxReady = false; // this is used because in case of generics 

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
}