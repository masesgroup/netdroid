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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*/

package org.mases.netdroid.generated.android.app;

public final class AppOpsManager_OnOpActiveChangedListener implements org.mases.jcobridge.IJCListener, android.app.AppOpsManager.OnOpActiveChangedListener {
    final org.mases.jcobridge.JCListener _internalListener;

    public AppOpsManager_OnOpActiveChangedListener(String key) throws org.mases.jcobridge.JCNativeException {
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
    public void onOpActiveChanged(java.lang.String arg0, int arg1, java.lang.String arg2, boolean arg3) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onOpActiveChanged", eventDataExchange, arg0, arg1, arg2, arg3); if (!eventDataExchange.getHasOverride()) throw new UnsupportedOperationException("The method shall be implemented in .NET side since does not have a default implementation within the JVM");
    }
    //@Override
    public void onOpActiveChanged(java.lang.String arg0, int arg1, java.lang.String arg2, java.lang.String arg3, int arg4, boolean arg5, int arg6, int arg7) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onOpActiveChanged8", eventDataExchange, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7); if (!eventDataExchange.getHasOverride()) android.app.AppOpsManager.OnOpActiveChangedListener.super.onOpActiveChanged(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
    }
    //@Override
    public void onOpActiveChangedDefault(java.lang.String arg0, int arg1, java.lang.String arg2, java.lang.String arg3, int arg4, boolean arg5, int arg6, int arg7) {
        android.app.AppOpsManager.OnOpActiveChangedListener.super.onOpActiveChanged(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
    }

}