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
*/

package org.mases.netdroid.generated.android.view;

public final class GestureDetector_SimpleOnGestureListener extends org.mases.jcobridge.JCListener implements android.view.GestureDetector.OnGestureListener, android.view.GestureDetector.OnDoubleTapListener, android.view.GestureDetector.OnContextClickListener {
    public GestureDetector_SimpleOnGestureListener(String key) throws org.mases.jcobridge.JCNativeException {
        super(key);
    }

    //@Override
    public boolean onContextClick(android.view.MotionEvent arg0) {
        raiseEvent("onContextClick", arg0); Object retVal = getReturnData(); return (boolean)retVal;
    }
    //@Override
    public boolean onDoubleTap(android.view.MotionEvent arg0) {
        raiseEvent("onDoubleTap", arg0); Object retVal = getReturnData(); return (boolean)retVal;
    }
    //@Override
    public boolean onDoubleTapEvent(android.view.MotionEvent arg0) {
        raiseEvent("onDoubleTapEvent", arg0); Object retVal = getReturnData(); return (boolean)retVal;
    }
    //@Override
    public boolean onDown(android.view.MotionEvent arg0) {
        raiseEvent("onDown", arg0); Object retVal = getReturnData(); return (boolean)retVal;
    }
    //@Override
    public boolean onFling(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3) {
        raiseEvent("onFling", arg0, arg1, arg2, arg3); Object retVal = getReturnData(); return (boolean)retVal;
    }
    //@Override
    public boolean onScroll(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3) {
        raiseEvent("onScroll", arg0, arg1, arg2, arg3); Object retVal = getReturnData(); return (boolean)retVal;
    }
    //@Override
    public boolean onSingleTapConfirmed(android.view.MotionEvent arg0) {
        raiseEvent("onSingleTapConfirmed", arg0); Object retVal = getReturnData(); return (boolean)retVal;
    }
    //@Override
    public boolean onSingleTapUp(android.view.MotionEvent arg0) {
        raiseEvent("onSingleTapUp", arg0); Object retVal = getReturnData(); return (boolean)retVal;
    }
    //@Override
    public void onLongPress(android.view.MotionEvent arg0) {
        raiseEvent("onLongPress", arg0);
    }
    //@Override
    public void onShowPress(android.view.MotionEvent arg0) {
        raiseEvent("onShowPress", arg0);
    }

}