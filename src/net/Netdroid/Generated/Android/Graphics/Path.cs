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
*  This file is generated by MASES.JNetReflector (ver. 2.5.4.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Graphics
{
    #region Path
    public partial class Path
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#%3Cinit%3E(android.graphics.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Path"/></param>
        public Path(Android.Graphics.Path arg0)
            : base(arg0)
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
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#getFillType()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Path.FillType"/></returns>
        public Android.Graphics.Path.FillType GetFillType()
        {
            return IExecuteWithSignature<Android.Graphics.Path.FillType>("getFillType", "()Landroid/graphics/Path$FillType;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#getPathIterator()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.PathIterator"/></returns>
        public Android.Graphics.PathIterator GetPathIterator()
        {
            return IExecuteWithSignature<Android.Graphics.PathIterator>("getPathIterator", "()Landroid/graphics/PathIterator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#interpolate(android.graphics.Path,float,android.graphics.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Path"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="Android.Graphics.Path"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Interpolate(Android.Graphics.Path arg0, float arg1, Android.Graphics.Path arg2)
        {
            return IExecute<bool>("interpolate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#isConvex()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool IsConvex()
        {
            return IExecuteWithSignature<bool>("isConvex", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#isEmpty()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEmpty()
        {
            return IExecuteWithSignature<bool>("isEmpty", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#isInterpolatable(android.graphics.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Path"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsInterpolatable(Android.Graphics.Path arg0)
        {
            return IExecuteWithSignature<bool>("isInterpolatable", "(Landroid/graphics/Path;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#isInverseFillType()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsInverseFillType()
        {
            return IExecuteWithSignature<bool>("isInverseFillType", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#isRect(android.graphics.RectF)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.RectF"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsRect(Android.Graphics.RectF arg0)
        {
            return IExecuteWithSignature<bool>("isRect", "(Landroid/graphics/RectF;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#op(android.graphics.Path,android.graphics.Path,android.graphics.Path.Op)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Path"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Path"/></param>
        /// <param name="arg2"><see cref="Android.Graphics.Path.Op"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OpMethod(Android.Graphics.Path arg0, Android.Graphics.Path arg1, Android.Graphics.Path.Op arg2)
        {
            return IExecute<bool>("op", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#op(android.graphics.Path,android.graphics.Path.Op)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Path"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Path.Op"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OpMethod(Android.Graphics.Path arg0, Android.Graphics.Path.Op arg1)
        {
            return IExecute<bool>("op", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#approximate(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public float[] Approximate(float arg0)
        {
            return IExecuteWithSignatureArray<float>("approximate", "(F)[F", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#getGenerationId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetGenerationId()
        {
            return IExecuteWithSignature<int>("getGenerationId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#addArc(android.graphics.RectF,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.RectF"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        public void AddArc(Android.Graphics.RectF arg0, float arg1, float arg2)
        {
            IExecute("addArc", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#addArc(float,float,float,float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <param name="arg4"><see cref="float"/></param>
        /// <param name="arg5"><see cref="float"/></param>
        public void AddArc(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5)
        {
            IExecute("addArc", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#addCircle(float,float,float,android.graphics.Path.Direction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="Android.Graphics.Path.Direction"/></param>
        public void AddCircle(float arg0, float arg1, float arg2, Android.Graphics.Path.Direction arg3)
        {
            IExecute("addCircle", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#addOval(android.graphics.RectF,android.graphics.Path.Direction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.RectF"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Path.Direction"/></param>
        public void AddOval(Android.Graphics.RectF arg0, Android.Graphics.Path.Direction arg1)
        {
            IExecute("addOval", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#addOval(float,float,float,float,android.graphics.Path.Direction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <param name="arg4"><see cref="Android.Graphics.Path.Direction"/></param>
        public void AddOval(float arg0, float arg1, float arg2, float arg3, Android.Graphics.Path.Direction arg4)
        {
            IExecute("addOval", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#addPath(android.graphics.Path,android.graphics.Matrix)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Path"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Matrix"/></param>
        public void AddPath(Android.Graphics.Path arg0, Android.Graphics.Matrix arg1)
        {
            IExecute("addPath", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#addPath(android.graphics.Path,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Path"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        public void AddPath(Android.Graphics.Path arg0, float arg1, float arg2)
        {
            IExecute("addPath", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#addPath(android.graphics.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Path"/></param>
        public void AddPath(Android.Graphics.Path arg0)
        {
            IExecuteWithSignature("addPath", "(Landroid/graphics/Path;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#addRect(android.graphics.RectF,android.graphics.Path.Direction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.RectF"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Path.Direction"/></param>
        public void AddRect(Android.Graphics.RectF arg0, Android.Graphics.Path.Direction arg1)
        {
            IExecute("addRect", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#addRect(float,float,float,float,android.graphics.Path.Direction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <param name="arg4"><see cref="Android.Graphics.Path.Direction"/></param>
        public void AddRect(float arg0, float arg1, float arg2, float arg3, Android.Graphics.Path.Direction arg4)
        {
            IExecute("addRect", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#addRoundRect(android.graphics.RectF,float,float,android.graphics.Path.Direction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.RectF"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="Android.Graphics.Path.Direction"/></param>
        public void AddRoundRect(Android.Graphics.RectF arg0, float arg1, float arg2, Android.Graphics.Path.Direction arg3)
        {
            IExecute("addRoundRect", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#addRoundRect(android.graphics.RectF,float[],android.graphics.Path.Direction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.RectF"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="Android.Graphics.Path.Direction"/></param>
        public void AddRoundRect(Android.Graphics.RectF arg0, float[] arg1, Android.Graphics.Path.Direction arg2)
        {
            IExecute("addRoundRect", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#addRoundRect(float,float,float,float,float,float,android.graphics.Path.Direction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <param name="arg4"><see cref="float"/></param>
        /// <param name="arg5"><see cref="float"/></param>
        /// <param name="arg6"><see cref="Android.Graphics.Path.Direction"/></param>
        public void AddRoundRect(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, Android.Graphics.Path.Direction arg6)
        {
            IExecute("addRoundRect", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#addRoundRect(float,float,float,float,float[],android.graphics.Path.Direction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <param name="arg4"><see cref="float"/></param>
        /// <param name="arg5"><see cref="Android.Graphics.Path.Direction"/></param>
        public void AddRoundRect(float arg0, float arg1, float arg2, float arg3, float[] arg4, Android.Graphics.Path.Direction arg5)
        {
            IExecute("addRoundRect", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#arcTo(android.graphics.RectF,float,float,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.RectF"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        public void ArcTo(Android.Graphics.RectF arg0, float arg1, float arg2, bool arg3)
        {
            IExecute("arcTo", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#arcTo(android.graphics.RectF,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.RectF"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        public void ArcTo(Android.Graphics.RectF arg0, float arg1, float arg2)
        {
            IExecute("arcTo", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#arcTo(float,float,float,float,float,float,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <param name="arg4"><see cref="float"/></param>
        /// <param name="arg5"><see cref="float"/></param>
        /// <param name="arg6"><see cref="bool"/></param>
        public void ArcTo(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, bool arg6)
        {
            IExecute("arcTo", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#computeBounds(android.graphics.RectF,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.RectF"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public void ComputeBounds(Android.Graphics.RectF arg0, bool arg1)
        {
            IExecute("computeBounds", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#conicTo(float,float,float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <param name="arg4"><see cref="float"/></param>
        public void ConicTo(float arg0, float arg1, float arg2, float arg3, float arg4)
        {
            IExecute("conicTo", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#cubicTo(float,float,float,float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <param name="arg4"><see cref="float"/></param>
        /// <param name="arg5"><see cref="float"/></param>
        public void CubicTo(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5)
        {
            IExecute("cubicTo", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#incReserve(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void IncReserve(int arg0)
        {
            IExecuteWithSignature("incReserve", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#lineTo(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public void LineTo(float arg0, float arg1)
        {
            IExecute("lineTo", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#moveTo(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public void MoveTo(float arg0, float arg1)
        {
            IExecute("moveTo", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#offset(float,float,android.graphics.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="Android.Graphics.Path"/></param>
        public void Offset(float arg0, float arg1, Android.Graphics.Path arg2)
        {
            IExecute("offset", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#offset(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public void Offset(float arg0, float arg1)
        {
            IExecute("offset", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#quadTo(float,float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        public void QuadTo(float arg0, float arg1, float arg2, float arg3)
        {
            IExecute("quadTo", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#rConicTo(float,float,float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <param name="arg4"><see cref="float"/></param>
        public void RConicTo(float arg0, float arg1, float arg2, float arg3, float arg4)
        {
            IExecute("rConicTo", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#rCubicTo(float,float,float,float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <param name="arg4"><see cref="float"/></param>
        /// <param name="arg5"><see cref="float"/></param>
        public void RCubicTo(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5)
        {
            IExecute("rCubicTo", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#reset()"/>
        /// </summary>
        public void Reset()
        {
            IExecuteWithSignature("reset", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#rewind()"/>
        /// </summary>
        public void Rewind()
        {
            IExecuteWithSignature("rewind", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#rLineTo(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public void RLineTo(float arg0, float arg1)
        {
            IExecute("rLineTo", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#rMoveTo(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public void RMoveTo(float arg0, float arg1)
        {
            IExecute("rMoveTo", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#rQuadTo(float,float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        public void RQuadTo(float arg0, float arg1, float arg2, float arg3)
        {
            IExecute("rQuadTo", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#set(android.graphics.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Path"/></param>
        public void Set(Android.Graphics.Path arg0)
        {
            IExecuteWithSignature("set", "(Landroid/graphics/Path;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#setFillType(android.graphics.Path.FillType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Path.FillType"/></param>
        public void SetFillType(Android.Graphics.Path.FillType arg0)
        {
            IExecuteWithSignature("setFillType", "(Landroid/graphics/Path$FillType;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#setLastPoint(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public void SetLastPoint(float arg0, float arg1)
        {
            IExecute("setLastPoint", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#toggleInverseFillType()"/>
        /// </summary>
        public void ToggleInverseFillType()
        {
            IExecuteWithSignature("toggleInverseFillType", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#transform(android.graphics.Matrix,android.graphics.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Matrix"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Path"/></param>
        public void Transform(Android.Graphics.Matrix arg0, Android.Graphics.Path arg1)
        {
            IExecute("transform", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Path.html#transform(android.graphics.Matrix)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Matrix"/></param>
        public void Transform(Android.Graphics.Matrix arg0)
        {
            IExecuteWithSignature("transform", "(Landroid/graphics/Matrix;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region Direction
        public partial class Direction
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Path.Direction.html#CCW"/>
            /// </summary>
            public static Android.Graphics.Path.Direction CCW { get { if (!_CCWReady) { _CCWContent = SGetField<Android.Graphics.Path.Direction>(LocalBridgeClazz, "CCW"); _CCWReady = true; } return _CCWContent; } }
            private static Android.Graphics.Path.Direction _CCWContent = default;
            private static bool _CCWReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Path.Direction.html#CW"/>
            /// </summary>
            public static Android.Graphics.Path.Direction CW { get { if (!_CWReady) { _CWContent = SGetField<Android.Graphics.Path.Direction>(LocalBridgeClazz, "CW"); _CWReady = true; } return _CWContent; } }
            private static Android.Graphics.Path.Direction _CWContent = default;
            private static bool _CWReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Path.Direction.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Graphics.Path.Direction"/></returns>
            public static Android.Graphics.Path.Direction ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Android.Graphics.Path.Direction>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Path$Direction;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Path.Direction.html#values()"/>
            /// </summary>
            /// <returns><see cref="Android.Graphics.Path.Direction"/></returns>
            public static Android.Graphics.Path.Direction[] Values()
            {
                return SExecuteWithSignatureArray<Android.Graphics.Path.Direction>(LocalBridgeClazz, "values", "()[Landroid/graphics/Path$Direction;");
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region FillType
        public partial class FillType
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Path.FillType.html#EVEN_ODD"/>
            /// </summary>
            public static Android.Graphics.Path.FillType EVEN_ODD { get { if (!_EVEN_ODDReady) { _EVEN_ODDContent = SGetField<Android.Graphics.Path.FillType>(LocalBridgeClazz, "EVEN_ODD"); _EVEN_ODDReady = true; } return _EVEN_ODDContent; } }
            private static Android.Graphics.Path.FillType _EVEN_ODDContent = default;
            private static bool _EVEN_ODDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Path.FillType.html#INVERSE_EVEN_ODD"/>
            /// </summary>
            public static Android.Graphics.Path.FillType INVERSE_EVEN_ODD { get { if (!_INVERSE_EVEN_ODDReady) { _INVERSE_EVEN_ODDContent = SGetField<Android.Graphics.Path.FillType>(LocalBridgeClazz, "INVERSE_EVEN_ODD"); _INVERSE_EVEN_ODDReady = true; } return _INVERSE_EVEN_ODDContent; } }
            private static Android.Graphics.Path.FillType _INVERSE_EVEN_ODDContent = default;
            private static bool _INVERSE_EVEN_ODDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Path.FillType.html#INVERSE_WINDING"/>
            /// </summary>
            public static Android.Graphics.Path.FillType INVERSE_WINDING { get { if (!_INVERSE_WINDINGReady) { _INVERSE_WINDINGContent = SGetField<Android.Graphics.Path.FillType>(LocalBridgeClazz, "INVERSE_WINDING"); _INVERSE_WINDINGReady = true; } return _INVERSE_WINDINGContent; } }
            private static Android.Graphics.Path.FillType _INVERSE_WINDINGContent = default;
            private static bool _INVERSE_WINDINGReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Path.FillType.html#WINDING"/>
            /// </summary>
            public static Android.Graphics.Path.FillType WINDING { get { if (!_WINDINGReady) { _WINDINGContent = SGetField<Android.Graphics.Path.FillType>(LocalBridgeClazz, "WINDING"); _WINDINGReady = true; } return _WINDINGContent; } }
            private static Android.Graphics.Path.FillType _WINDINGContent = default;
            private static bool _WINDINGReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Path.FillType.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Graphics.Path.FillType"/></returns>
            public static Android.Graphics.Path.FillType ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Android.Graphics.Path.FillType>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Path$FillType;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Path.FillType.html#values()"/>
            /// </summary>
            /// <returns><see cref="Android.Graphics.Path.FillType"/></returns>
            public static Android.Graphics.Path.FillType[] Values()
            {
                return SExecuteWithSignatureArray<Android.Graphics.Path.FillType>(LocalBridgeClazz, "values", "()[Landroid/graphics/Path$FillType;");
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Op
        public partial class Op
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Path.Op.html#DIFFERENCE"/>
            /// </summary>
            public static Android.Graphics.Path.Op DIFFERENCE { get { if (!_DIFFERENCEReady) { _DIFFERENCEContent = SGetField<Android.Graphics.Path.Op>(LocalBridgeClazz, "DIFFERENCE"); _DIFFERENCEReady = true; } return _DIFFERENCEContent; } }
            private static Android.Graphics.Path.Op _DIFFERENCEContent = default;
            private static bool _DIFFERENCEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Path.Op.html#INTERSECT"/>
            /// </summary>
            public static Android.Graphics.Path.Op INTERSECT { get { if (!_INTERSECTReady) { _INTERSECTContent = SGetField<Android.Graphics.Path.Op>(LocalBridgeClazz, "INTERSECT"); _INTERSECTReady = true; } return _INTERSECTContent; } }
            private static Android.Graphics.Path.Op _INTERSECTContent = default;
            private static bool _INTERSECTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Path.Op.html#REVERSE_DIFFERENCE"/>
            /// </summary>
            public static Android.Graphics.Path.Op REVERSE_DIFFERENCE { get { if (!_REVERSE_DIFFERENCEReady) { _REVERSE_DIFFERENCEContent = SGetField<Android.Graphics.Path.Op>(LocalBridgeClazz, "REVERSE_DIFFERENCE"); _REVERSE_DIFFERENCEReady = true; } return _REVERSE_DIFFERENCEContent; } }
            private static Android.Graphics.Path.Op _REVERSE_DIFFERENCEContent = default;
            private static bool _REVERSE_DIFFERENCEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Path.Op.html#UNION"/>
            /// </summary>
            public static Android.Graphics.Path.Op UNION { get { if (!_UNIONReady) { _UNIONContent = SGetField<Android.Graphics.Path.Op>(LocalBridgeClazz, "UNION"); _UNIONReady = true; } return _UNIONContent; } }
            private static Android.Graphics.Path.Op _UNIONContent = default;
            private static bool _UNIONReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Path.Op.html#XOR"/>
            /// </summary>
            public static Android.Graphics.Path.Op XOR { get { if (!_XORReady) { _XORContent = SGetField<Android.Graphics.Path.Op>(LocalBridgeClazz, "XOR"); _XORReady = true; } return _XORContent; } }
            private static Android.Graphics.Path.Op _XORContent = default;
            private static bool _XORReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Path.Op.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Graphics.Path.Op"/></returns>
            public static Android.Graphics.Path.Op ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Android.Graphics.Path.Op>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Path$Op;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Path.Op.html#values()"/>
            /// </summary>
            /// <returns><see cref="Android.Graphics.Path.Op"/></returns>
            public static Android.Graphics.Path.Op[] Values()
            {
                return SExecuteWithSignatureArray<Android.Graphics.Path.Op>(LocalBridgeClazz, "values", "()[Landroid/graphics/Path$Op;");
            }

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