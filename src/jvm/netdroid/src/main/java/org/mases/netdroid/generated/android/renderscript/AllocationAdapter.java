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
*/

package org.mases.netdroid.generated.android.renderscript;

public final class AllocationAdapter extends org.mases.jcobridge.JCListener implements  {
    public AllocationAdapter(String key) throws org.mases.jcobridge.JCNativeException {
        super(key);
    }

    //@Override
    public android.renderscript.Element getElement() {
        raiseEvent("getElement"); Object retVal = getReturnData(); return (android.renderscript.Element)retVal;
    }
    //@Override
    public android.renderscript.Type getType() {
        raiseEvent("getType"); Object retVal = getReturnData(); return (android.renderscript.Type)retVal;
    }
    //@Override
    public android.view.Surface getSurface() {
        raiseEvent("getSurface"); Object retVal = getReturnData(); return (android.view.Surface)retVal;
    }
    //@Override
    public int getBytesSize() {
        raiseEvent("getBytesSize"); Object retVal = getReturnData(); return (int)retVal;
    }
    //@Override
    public int getUsage() {
        raiseEvent("getUsage"); Object retVal = getReturnData(); return (int)retVal;
    }
    //@Override
    public java.lang.String getName() {
        raiseEvent("getName"); Object retVal = getReturnData(); return (java.lang.String)retVal;
    }
    //@Override
    public java.nio.ByteBuffer getByteBuffer() {
        raiseEvent("getByteBuffer"); Object retVal = getReturnData(); return (java.nio.ByteBuffer)retVal;
    }
    //@Override
    public long getStride() {
        raiseEvent("getStride"); Object retVal = getReturnData(); return (long)retVal;
    }
    //@Override
    public long getTimeStamp() {
        raiseEvent("getTimeStamp"); Object retVal = getReturnData(); return (long)retVal;
    }
    //@Override
    public void resize(int arg0) {
        raiseEvent("resize", arg0);
    }
    //@Override
    public void copy1DRangeFrom(int arg0, int arg1, android.renderscript.Allocation arg2, int arg3) {
        raiseEvent("copy1DRangeFrom", arg0, arg1, arg2, arg3);
    }
    //@Override
    public void copy1DRangeFrom(int arg0, int arg1, byte[] arg2) {
        raiseEvent("copy1DRangeFrom3", arg0, arg1, arg2);
    }
    //@Override
    public void copy1DRangeFrom(int arg0, int arg1, float[] arg2) {
        raiseEvent("copy1DRangeFrom3_2", arg0, arg1, arg2);
    }
    //@Override
    public void copy1DRangeFrom(int arg0, int arg1, int[] arg2) {
        raiseEvent("copy1DRangeFrom3_3", arg0, arg1, arg2);
    }
    //@Override
    public void copy1DRangeFrom(int arg0, int arg1, java.lang.Object arg2) {
        raiseEvent("copy1DRangeFrom3_4", arg0, arg1, arg2);
    }
    //@Override
    public void copy1DRangeFrom(int arg0, int arg1, short[] arg2) {
        raiseEvent("copy1DRangeFrom3_5", arg0, arg1, arg2);
    }
    //@Override
    public void copy1DRangeFromUnchecked(int arg0, int arg1, byte[] arg2) {
        raiseEvent("copy1DRangeFromUnchecked", arg0, arg1, arg2);
    }
    //@Override
    public void copy1DRangeFromUnchecked(int arg0, int arg1, float[] arg2) {
        raiseEvent("copy1DRangeFromUnchecked3", arg0, arg1, arg2);
    }
    //@Override
    public void copy1DRangeFromUnchecked(int arg0, int arg1, int[] arg2) {
        raiseEvent("copy1DRangeFromUnchecked3_2", arg0, arg1, arg2);
    }
    //@Override
    public void copy1DRangeFromUnchecked(int arg0, int arg1, java.lang.Object arg2) {
        raiseEvent("copy1DRangeFromUnchecked3_3", arg0, arg1, arg2);
    }
    //@Override
    public void copy1DRangeFromUnchecked(int arg0, int arg1, short[] arg2) {
        raiseEvent("copy1DRangeFromUnchecked3_4", arg0, arg1, arg2);
    }
    //@Override
    public void copy1DRangeTo(int arg0, int arg1, byte[] arg2) {
        raiseEvent("copy1DRangeTo", arg0, arg1, arg2);
    }
    //@Override
    public void copy1DRangeTo(int arg0, int arg1, float[] arg2) {
        raiseEvent("copy1DRangeTo3", arg0, arg1, arg2);
    }
    //@Override
    public void copy1DRangeTo(int arg0, int arg1, int[] arg2) {
        raiseEvent("copy1DRangeTo3_2", arg0, arg1, arg2);
    }
    //@Override
    public void copy1DRangeTo(int arg0, int arg1, java.lang.Object arg2) {
        raiseEvent("copy1DRangeTo3_3", arg0, arg1, arg2);
    }
    //@Override
    public void copy1DRangeTo(int arg0, int arg1, short[] arg2) {
        raiseEvent("copy1DRangeTo3_4", arg0, arg1, arg2);
    }
    //@Override
    public void copy1DRangeToUnchecked(int arg0, int arg1, byte[] arg2) {
        raiseEvent("copy1DRangeToUnchecked", arg0, arg1, arg2);
    }
    //@Override
    public void copy1DRangeToUnchecked(int arg0, int arg1, float[] arg2) {
        raiseEvent("copy1DRangeToUnchecked3", arg0, arg1, arg2);
    }
    //@Override
    public void copy1DRangeToUnchecked(int arg0, int arg1, int[] arg2) {
        raiseEvent("copy1DRangeToUnchecked3_2", arg0, arg1, arg2);
    }
    //@Override
    public void copy1DRangeToUnchecked(int arg0, int arg1, java.lang.Object arg2) {
        raiseEvent("copy1DRangeToUnchecked3_3", arg0, arg1, arg2);
    }
    //@Override
    public void copy1DRangeToUnchecked(int arg0, int arg1, short[] arg2) {
        raiseEvent("copy1DRangeToUnchecked3_4", arg0, arg1, arg2);
    }
    //@Override
    public void copy2DRangeFrom(int arg0, int arg1, android.graphics.Bitmap arg2) {
        raiseEvent("copy2DRangeFrom", arg0, arg1, arg2);
    }
    //@Override
    public void copy2DRangeFrom(int arg0, int arg1, int arg2, int arg3, android.renderscript.Allocation arg4, int arg5, int arg6) {
        raiseEvent("copy2DRangeFrom7", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
    }
    //@Override
    public void copy2DRangeFrom(int arg0, int arg1, int arg2, int arg3, byte[] arg4) {
        raiseEvent("copy2DRangeFrom5_2", arg0, arg1, arg2, arg3, arg4);
    }
    //@Override
    public void copy2DRangeFrom(int arg0, int arg1, int arg2, int arg3, float[] arg4) {
        raiseEvent("copy2DRangeFrom5_3", arg0, arg1, arg2, arg3, arg4);
    }
    //@Override
    public void copy2DRangeFrom(int arg0, int arg1, int arg2, int arg3, int[] arg4) {
        raiseEvent("copy2DRangeFrom5_4", arg0, arg1, arg2, arg3, arg4);
    }
    //@Override
    public void copy2DRangeFrom(int arg0, int arg1, int arg2, int arg3, java.lang.Object arg4) {
        raiseEvent("copy2DRangeFrom5_5", arg0, arg1, arg2, arg3, arg4);
    }
    //@Override
    public void copy2DRangeFrom(int arg0, int arg1, int arg2, int arg3, short[] arg4) {
        raiseEvent("copy2DRangeFrom5_6", arg0, arg1, arg2, arg3, arg4);
    }
    //@Override
    public void copy2DRangeTo(int arg0, int arg1, int arg2, int arg3, byte[] arg4) {
        raiseEvent("copy2DRangeTo", arg0, arg1, arg2, arg3, arg4);
    }
    //@Override
    public void copy2DRangeTo(int arg0, int arg1, int arg2, int arg3, float[] arg4) {
        raiseEvent("copy2DRangeTo5", arg0, arg1, arg2, arg3, arg4);
    }
    //@Override
    public void copy2DRangeTo(int arg0, int arg1, int arg2, int arg3, int[] arg4) {
        raiseEvent("copy2DRangeTo5_2", arg0, arg1, arg2, arg3, arg4);
    }
    //@Override
    public void copy2DRangeTo(int arg0, int arg1, int arg2, int arg3, java.lang.Object arg4) {
        raiseEvent("copy2DRangeTo5_3", arg0, arg1, arg2, arg3, arg4);
    }
    //@Override
    public void copy2DRangeTo(int arg0, int arg1, int arg2, int arg3, short[] arg4) {
        raiseEvent("copy2DRangeTo5_4", arg0, arg1, arg2, arg3, arg4);
    }
    //@Override
    public void copy3DRangeFrom(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, android.renderscript.Allocation arg6, int arg7, int arg8, int arg9) {
        raiseEvent("copy3DRangeFrom", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
    }
    //@Override
    public void copy3DRangeFrom(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, java.lang.Object arg6) {
        raiseEvent("copy3DRangeFrom7", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
    }
    //@Override
    public void copy3DRangeTo(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, java.lang.Object arg6) {
        raiseEvent("copy3DRangeTo", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
    }
    //@Override
    public void copyFrom(android.graphics.Bitmap arg0) {
        raiseEvent("copyFrom", arg0);
    }
    //@Override
    public void copyFrom(android.renderscript.Allocation arg0) {
        raiseEvent("copyFrom1", arg0);
    }
    //@Override
    public void copyFrom(android.renderscript.BaseObj[] arg0) {
        raiseEvent("copyFrom1_2", arg0);
    }
    //@Override
    public void copyFrom(byte[] arg0) {
        raiseEvent("copyFrom1_3", arg0);
    }
    //@Override
    public void copyFrom(float[] arg0) {
        raiseEvent("copyFrom1_4", arg0);
    }
    //@Override
    public void copyFrom(int[] arg0) {
        raiseEvent("copyFrom1_5", arg0);
    }
    //@Override
    public void copyFrom(java.lang.Object arg0) {
        raiseEvent("copyFrom1_6", arg0);
    }
    //@Override
    public void copyFrom(short[] arg0) {
        raiseEvent("copyFrom1_7", arg0);
    }
    //@Override
    public void copyFromUnchecked(byte[] arg0) {
        raiseEvent("copyFromUnchecked", arg0);
    }
    //@Override
    public void copyFromUnchecked(float[] arg0) {
        raiseEvent("copyFromUnchecked1", arg0);
    }
    //@Override
    public void copyFromUnchecked(int[] arg0) {
        raiseEvent("copyFromUnchecked1_2", arg0);
    }
    //@Override
    public void copyFromUnchecked(java.lang.Object arg0) {
        raiseEvent("copyFromUnchecked1_3", arg0);
    }
    //@Override
    public void copyFromUnchecked(short[] arg0) {
        raiseEvent("copyFromUnchecked1_4", arg0);
    }
    //@Override
    public void copyTo(android.graphics.Bitmap arg0) {
        raiseEvent("copyTo", arg0);
    }
    //@Override
    public void copyTo(byte[] arg0) {
        raiseEvent("copyTo1", arg0);
    }
    //@Override
    public void copyTo(float[] arg0) {
        raiseEvent("copyTo1_2", arg0);
    }
    //@Override
    public void copyTo(int[] arg0) {
        raiseEvent("copyTo1_3", arg0);
    }
    //@Override
    public void copyTo(java.lang.Object arg0) {
        raiseEvent("copyTo1_4", arg0);
    }
    //@Override
    public void copyTo(short[] arg0) {
        raiseEvent("copyTo1_5", arg0);
    }
    //@Override
    public void destroy() {
        raiseEvent("destroy");
    }
    //@Override
    public void generateMipmaps() {
        raiseEvent("generateMipmaps");
    }
    //@Override
    public void ioReceive() {
        raiseEvent("ioReceive");
    }
    //@Override
    public void ioSend() {
        raiseEvent("ioSend");
    }
    //@Override
    public void setAutoPadding(boolean arg0) {
        raiseEvent("setAutoPadding", arg0);
    }
    //@Override
    public void setFromFieldPacker(int arg0, android.renderscript.FieldPacker arg1) {
        raiseEvent("setFromFieldPacker", arg0, arg1);
    }
    //@Override
    public void setFromFieldPacker(int arg0, int arg1, android.renderscript.FieldPacker arg2) {
        raiseEvent("setFromFieldPacker3", arg0, arg1, arg2);
    }
    //@Override
    public void setFromFieldPacker(int arg0, int arg1, int arg2, int arg3, android.renderscript.FieldPacker arg4) {
        raiseEvent("setFromFieldPacker5_2", arg0, arg1, arg2, arg3, arg4);
    }
    //@Override
    public void setOnBufferAvailableListener(android.renderscript.Allocation.OnBufferAvailableListener arg0) {
        raiseEvent("setOnBufferAvailableListener", arg0);
    }
    //@Override
    public void setSurface(android.view.Surface arg0) {
        raiseEvent("setSurface", arg0);
    }
    //@Override
    public void syncAll(int arg0) {
        raiseEvent("syncAll", arg0);
    }
    //@Override
    public void setFace(android.renderscript.Type.CubemapFace arg0) {
        raiseEvent("setFace", arg0);
    }
    //@Override
    public void setLOD(int arg0) {
        raiseEvent("setLOD", arg0);
    }
    //@Override
    public void setX(int arg0) {
        raiseEvent("setX", arg0);
    }
    //@Override
    public void setY(int arg0) {
        raiseEvent("setY", arg0);
    }
    //@Override
    public void setZ(int arg0) {
        raiseEvent("setZ", arg0);
    }
    //@Override
    public void setName(java.lang.String arg0) {
        raiseEvent("setName", arg0);
    }

}