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

package org.mases.netdroid.developed.java.util.function;

import org.mases.jcobridge.*;

/**
 * The {@link Function} class represents a generic implementation of
 * {@link java.util.function.Function}
 */
public final class Function extends JCListener implements java.util.function.Function {
    public Function(String key) throws JCNativeException {
        super(key);
    }

    @Override
    public Object apply(Object e) {
        raiseEvent("apply", e);
        Object retVal = getReturnData();
        return retVal;
    }
}