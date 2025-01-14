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
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util
{
    #region SplittableRandom declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/util/SplittableRandom.html"/>
    /// </summary>
    public partial class SplittableRandom : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SplittableRandom>
    {
        const string _bridgeClassName = "java.util.SplittableRandom";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SplittableRandom() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SplittableRandom(params object[] args) : base(args) { }
    
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
    
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    
        // TODO: complete the class
    
    }
    #endregion

    #region SplittableRandom implementation
    public partial class SplittableRandom : Java.Util.RandomNs.IRandomGenerator
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SplittableRandom.html#%3Cinit%3E(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public SplittableRandom(long arg0)
            : base(arg0)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.SplittableRandom"/> to <see cref="Java.Util.RandomNs.RandomGenerator"/>
        /// </summary>
        public static implicit operator Java.Util.RandomNs.RandomGenerator(Java.Util.SplittableRandom t) => t.Cast<Java.Util.RandomNs.RandomGenerator>();
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SplittableRandom.html#nextInt()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int NextInt()
        {
            return IExecuteWithSignature<int>("nextInt", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SplittableRandom.html#split()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.RandomNs.RandomGenerator.SplittableGenerator"/></returns>
        public Java.Util.RandomNs.RandomGenerator.SplittableGenerator Split()
        {
            return IExecuteWithSignature<Java.Util.RandomNs.RandomGenerator.SplittableGenerator>("split", "()Ljava/util/random/RandomGenerator$SplittableGenerator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SplittableRandom.html#split(java.util.random.RandomGenerator.SplittableGenerator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.RandomNs.RandomGenerator.SplittableGenerator"/></param>
        /// <returns><see cref="Java.Util.RandomNs.RandomGenerator.SplittableGenerator"/></returns>
        public Java.Util.RandomNs.RandomGenerator.SplittableGenerator Split(Java.Util.RandomNs.RandomGenerator.SplittableGenerator arg0)
        {
            return IExecuteWithSignature<Java.Util.RandomNs.RandomGenerator.SplittableGenerator>("split", "(Ljava/util/random/RandomGenerator$SplittableGenerator;)Ljava/util/random/RandomGenerator$SplittableGenerator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SplittableRandom.html#doubles()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public Java.Util.Stream.DoubleStream Doubles()
        {
            return IExecuteWithSignature<Java.Util.Stream.DoubleStream>("doubles", "()Ljava/util/stream/DoubleStream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SplittableRandom.html#doubles(double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public Java.Util.Stream.DoubleStream Doubles(double arg0, double arg1)
        {
            return IExecuteWithSignature<Java.Util.Stream.DoubleStream>("doubles", "(DD)Ljava/util/stream/DoubleStream;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SplittableRandom.html#doubles(long,double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public Java.Util.Stream.DoubleStream Doubles(long arg0, double arg1, double arg2)
        {
            return IExecuteWithSignature<Java.Util.Stream.DoubleStream>("doubles", "(JDD)Ljava/util/stream/DoubleStream;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SplittableRandom.html#doubles(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public Java.Util.Stream.DoubleStream Doubles(long arg0)
        {
            return IExecuteWithSignature<Java.Util.Stream.DoubleStream>("doubles", "(J)Ljava/util/stream/DoubleStream;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SplittableRandom.html#ints()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Stream.IntStream"/></returns>
        public Java.Util.Stream.IntStream Ints()
        {
            return IExecuteWithSignature<Java.Util.Stream.IntStream>("ints", "()Ljava/util/stream/IntStream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SplittableRandom.html#ints(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Stream.IntStream"/></returns>
        public Java.Util.Stream.IntStream Ints(int arg0, int arg1)
        {
            return IExecuteWithSignature<Java.Util.Stream.IntStream>("ints", "(II)Ljava/util/stream/IntStream;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SplittableRandom.html#ints(long,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Stream.IntStream"/></returns>
        public Java.Util.Stream.IntStream Ints(long arg0, int arg1, int arg2)
        {
            return IExecuteWithSignature<Java.Util.Stream.IntStream>("ints", "(JII)Ljava/util/stream/IntStream;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SplittableRandom.html#ints(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Stream.IntStream"/></returns>
        public Java.Util.Stream.IntStream Ints(long arg0)
        {
            return IExecuteWithSignature<Java.Util.Stream.IntStream>("ints", "(J)Ljava/util/stream/IntStream;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SplittableRandom.html#longs()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public Java.Util.Stream.LongStream Longs()
        {
            return IExecuteWithSignature<Java.Util.Stream.LongStream>("longs", "()Ljava/util/stream/LongStream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SplittableRandom.html#longs(long,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public Java.Util.Stream.LongStream Longs(long arg0, long arg1, long arg2)
        {
            return IExecuteWithSignature<Java.Util.Stream.LongStream>("longs", "(JJJ)Ljava/util/stream/LongStream;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SplittableRandom.html#longs(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public Java.Util.Stream.LongStream Longs(long arg0, long arg1)
        {
            return IExecuteWithSignature<Java.Util.Stream.LongStream>("longs", "(JJ)Ljava/util/stream/LongStream;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SplittableRandom.html#longs(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public Java.Util.Stream.LongStream Longs(long arg0)
        {
            return IExecuteWithSignature<Java.Util.Stream.LongStream>("longs", "(J)Ljava/util/stream/LongStream;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SplittableRandom.html#splits()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public Java.Util.Stream.Stream<Java.Util.RandomNs.RandomGenerator.SplittableGenerator> Splits()
        {
            return IExecuteWithSignature<Java.Util.Stream.Stream<Java.Util.RandomNs.RandomGenerator.SplittableGenerator>>("splits", "()Ljava/util/stream/Stream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SplittableRandom.html#splits(java.util.random.RandomGenerator.SplittableGenerator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.RandomNs.RandomGenerator.SplittableGenerator"/></param>
        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public Java.Util.Stream.Stream<Java.Util.RandomNs.RandomGenerator.SplittableGenerator> Splits(Java.Util.RandomNs.RandomGenerator.SplittableGenerator arg0)
        {
            return IExecuteWithSignature<Java.Util.Stream.Stream<Java.Util.RandomNs.RandomGenerator.SplittableGenerator>>("splits", "(Ljava/util/random/RandomGenerator$SplittableGenerator;)Ljava/util/stream/Stream;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SplittableRandom.html#splits(long,java.util.random.RandomGenerator.SplittableGenerator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.RandomNs.RandomGenerator.SplittableGenerator"/></param>
        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public Java.Util.Stream.Stream<Java.Util.RandomNs.RandomGenerator.SplittableGenerator> Splits(long arg0, Java.Util.RandomNs.RandomGenerator.SplittableGenerator arg1)
        {
            return IExecuteWithSignature<Java.Util.Stream.Stream<Java.Util.RandomNs.RandomGenerator.SplittableGenerator>>("splits", "(JLjava/util/random/RandomGenerator$SplittableGenerator;)Ljava/util/stream/Stream;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SplittableRandom.html#splits(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public Java.Util.Stream.Stream<Java.Util.RandomNs.RandomGenerator.SplittableGenerator> Splits(long arg0)
        {
            return IExecuteWithSignature<Java.Util.Stream.Stream<Java.Util.RandomNs.RandomGenerator.SplittableGenerator>>("splits", "(J)Ljava/util/stream/Stream;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SplittableRandom.html#nextLong()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long NextLong()
        {
            return IExecuteWithSignature<long>("nextLong", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SplittableRandom.html#nextBytes(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        public void NextBytes(byte[] arg0)
        {
            IExecuteWithSignature("nextBytes", "([B)V", new object[] { arg0 });
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}