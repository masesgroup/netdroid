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
*/

package org.mases.netdroid.generated.android.widget;

public final class BaseAdapter extends org.mases.jcobridge.JCListener implements android.widget.ListAdapter, android.widget.SpinnerAdapter {
    public BaseAdapter(String key) throws org.mases.jcobridge.JCNativeException {
        super(key);
    }

    //@Override
    public android.view.View getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) {
        raiseEvent("getView", arg0, arg1, arg2); Object retVal = getReturnData(); return (android.view.View)retVal;
    }
    //@Override
    public int getCount() {
        raiseEvent("getCount"); Object retVal = getReturnData(); return (int)retVal;
    }
    //@Override
    public java.lang.Object getItem(int arg0) {
        raiseEvent("getItem", arg0); Object retVal = getReturnData(); return (java.lang.Object)retVal;
    }
    //@Override
    public long getItemId(int arg0) {
        raiseEvent("getItemId", arg0); Object retVal = getReturnData(); return (long)retVal;
    }
    //@Override
    public android.view.View getDropDownView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) {
        raiseEvent("getDropDownView", arg0, arg1, arg2); Object retVal = getReturnData(); return (android.view.View)retVal;
    }
    //@Override
    public boolean areAllItemsEnabled() {
        raiseEvent("areAllItemsEnabled"); Object retVal = getReturnData(); return (boolean)retVal;
    }
    //@Override
    public boolean hasStableIds() {
        raiseEvent("hasStableIds"); Object retVal = getReturnData(); return (boolean)retVal;
    }
    //@Override
    public boolean isEmpty() {
        raiseEvent("isEmpty"); Object retVal = getReturnData(); return (boolean)retVal;
    }
    //@Override
    public boolean isEnabled(int arg0) {
        raiseEvent("isEnabled", arg0); Object retVal = getReturnData(); return (boolean)retVal;
    }
    //@Override
    public int getItemViewType(int arg0) {
        raiseEvent("getItemViewType", arg0); Object retVal = getReturnData(); return (int)retVal;
    }
    //@Override
    public int getViewTypeCount() {
        raiseEvent("getViewTypeCount"); Object retVal = getReturnData(); return (int)retVal;
    }
    //@Override
    public java.lang.CharSequence[] getAutofillOptions() {
        raiseEvent("getAutofillOptions"); Object retVal = getReturnData(); return (java.lang.CharSequence[])retVal;
    }
    //@Override
    public void notifyDataSetChanged() {
        raiseEvent("notifyDataSetChanged");
    }
    //@Override
    public void notifyDataSetInvalidated() {
        raiseEvent("notifyDataSetInvalidated");
    }
    //@Override
    public void registerDataSetObserver(android.database.DataSetObserver arg0) {
        raiseEvent("registerDataSetObserver", arg0);
    }
    //@Override
    public void setAutofillOptions(java.lang.CharSequence[] arg0) {
        raiseEvent("setAutofillOptions", arg0);
    }
    //@Override
    public void unregisterDataSetObserver(android.database.DataSetObserver arg0) {
        raiseEvent("unregisterDataSetObserver", arg0);
    }

}