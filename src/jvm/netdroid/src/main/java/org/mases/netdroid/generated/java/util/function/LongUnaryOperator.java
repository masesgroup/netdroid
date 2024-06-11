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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*/

package org.mases.netdroid.generated.java.util.function;

public final class LongUnaryOperator extends org.mases.jcobridge.JCListener implements java.util.function.LongUnaryOperator {
    public LongUnaryOperator(String key) throws org.mases.jcobridge.JCNativeException {
        super(key);
    }

    //@Override
    public long applyAsLong(long arg0) {
        raiseEvent("applyAsLong", arg0); Object retVal = getReturnData(); return (long)retVal;
    }
    //@Override
    public java.util.function.LongUnaryOperator andThen(java.util.function.LongUnaryOperator arg0) {
        raiseEvent("andThen", arg0); Object retVal = getReturnData(); return (java.util.function.LongUnaryOperator)retVal;
    }
    //@Override
    public java.util.function.LongUnaryOperator andThenDefault(java.util.function.LongUnaryOperator arg0) {
        return java.util.function.LongUnaryOperator.super.andThen(arg0);
    }
    //@Override
    public java.util.function.LongUnaryOperator compose(java.util.function.LongUnaryOperator arg0) {
        raiseEvent("compose", arg0); Object retVal = getReturnData(); return (java.util.function.LongUnaryOperator)retVal;
    }
    //@Override
    public java.util.function.LongUnaryOperator composeDefault(java.util.function.LongUnaryOperator arg0) {
        return java.util.function.LongUnaryOperator.super.compose(arg0);
    }

}