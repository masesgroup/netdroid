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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*/

package org.mases.netdroid.generated.android.text.method;

public final class BaseKeyListener extends android.text.method.BaseKeyListener implements org.mases.jcobridge.IJCListener {
    final org.mases.jcobridge.JCListener _internalListener;

    public BaseKeyListener(String key) throws org.mases.jcobridge.JCNativeException {
        super();
        _internalListener = new org.mases.jcobridge.JCListener(key);
    }

    public synchronized void release() {
       _internalListener.release();
    }
    
    public synchronized void raiseEvent(String eventName) {
       _internalListener.raiseEvent(eventName);
    }
    
    public synchronized void raiseEvent(String eventName, Object e) {
       _internalListener.raiseEvent(eventName, e);
    }
    
    public synchronized void raiseEvent(String eventName, Object e, Object... objects) {
       _internalListener.raiseEvent(eventName, e, objects);
    }
    
    public Object getEventData() {
       return _internalListener.getEventData();
    }
    
    public boolean hasExtraData() {
       return _internalListener.hasExtraData();
    }
    
    public int extraDataLength() {
       return _internalListener.extraDataLength();
    }
    
    public Object[] extraData() {
       return _internalListener.extraData();
    }
    
    public Object getReturnData() {
       return _internalListener.getReturnData();
    }
    
    public void setReturnData(Object retData) {
       _internalListener.setReturnData(retData);
    }

    //@Override
    public int getInputType() {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("getInputType", eventDataExchange); if (!eventDataExchange.getHasOverride()) throw new UnsupportedOperationException("The method shall be implemented in .NET side since does not have a default implementation within the JVM"); Object retVal = eventDataExchange.getReturnData(); return (int)retVal;
    }
    //@Override
    public boolean backspace(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("backspace", eventDataExchange, arg0, arg1, arg2, arg3); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.backspace(arg0, arg1, arg2, arg3); else retVal = eventDataExchange.getReturnData(); return (boolean)retVal;
    }
    //@Override
    public boolean forwardDelete(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("forwardDelete", eventDataExchange, arg0, arg1, arg2, arg3); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.forwardDelete(arg0, arg1, arg2, arg3); else retVal = eventDataExchange.getReturnData(); return (boolean)retVal;
    }
    //@Override
    public boolean onKeyDown(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onKeyDown", eventDataExchange, arg0, arg1, arg2, arg3); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.onKeyDown(arg0, arg1, arg2, arg3); else retVal = eventDataExchange.getReturnData(); return (boolean)retVal;
    }
    //@Override
    public boolean onKeyOther(android.view.View arg0, android.text.Editable arg1, android.view.KeyEvent arg2) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onKeyOther", eventDataExchange, arg0, arg1, arg2); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.onKeyOther(arg0, arg1, arg2); else retVal = eventDataExchange.getReturnData(); return (boolean)retVal;
    }
    //@Override
    public boolean onKeyUp(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onKeyUp", eventDataExchange, arg0, arg1, arg2, arg3); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.onKeyUp(arg0, arg1, arg2, arg3); else retVal = eventDataExchange.getReturnData(); return (boolean)retVal;
    }
    //@Override
    public long clearMetaKeyState(long arg0, int arg1) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("clearMetaKeyState", eventDataExchange, arg0, arg1); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = super.clearMetaKeyState(arg0, arg1); else retVal = eventDataExchange.getReturnData(); return (long)retVal;
    }
    //@Override
    public void clearMetaKeyState(android.view.View arg0, android.text.Editable arg1, int arg2) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("clearMetaKeyState3", eventDataExchange, arg0, arg1, arg2); if (!eventDataExchange.getHasOverride()) super.clearMetaKeyState(arg0, arg1, arg2);
    }

}