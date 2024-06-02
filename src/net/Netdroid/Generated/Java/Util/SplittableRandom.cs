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
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util
{
    #region SplittableRandom
    public partial class SplittableRandom
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

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SplittableRandom.html#nextBoolean()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool NextBoolean()
        {
            return IExecute<bool>("nextBoolean");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SplittableRandom.html#nextDouble()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        public double NextDouble()
        {
            return IExecute<double>("nextDouble");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SplittableRandom.html#nextDouble(double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public double NextDouble(double arg0, double arg1)
        {
            return IExecute<double>("nextDouble", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SplittableRandom.html#nextDouble(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public double NextDouble(double arg0)
        {
            return IExecute<double>("nextDouble", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SplittableRandom.html#nextInt()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int NextInt()
        {
            return IExecuteWithSignature<int>("nextInt", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SplittableRandom.html#nextInt(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int NextInt(int arg0, int arg1)
        {
            return IExecute<int>("nextInt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SplittableRandom.html#nextInt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int NextInt(int arg0)
        {
            return IExecute<int>("nextInt", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SplittableRandom.html#split()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.SplittableRandom"/></returns>
        public Java.Util.SplittableRandom Split()
        {
            return IExecuteWithSignature<Java.Util.SplittableRandom>("split", "()Ljava/util/SplittableRandom;");
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
            return IExecute<Java.Util.Stream.DoubleStream>("doubles", arg0, arg1);
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
            return IExecute<Java.Util.Stream.DoubleStream>("doubles", arg0, arg1, arg2);
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
            return IExecute<Java.Util.Stream.IntStream>("ints", arg0, arg1);
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
            return IExecute<Java.Util.Stream.IntStream>("ints", arg0, arg1, arg2);
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
            return IExecute<Java.Util.Stream.LongStream>("longs", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SplittableRandom.html#longs(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public Java.Util.Stream.LongStream Longs(long arg0, long arg1)
        {
            return IExecute<Java.Util.Stream.LongStream>("longs", arg0, arg1);
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
        /// <see href="https://developer.android.com/reference/java/util/SplittableRandom.html#nextLong()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long NextLong()
        {
            return IExecuteWithSignature<long>("nextLong", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SplittableRandom.html#nextLong(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long NextLong(long arg0, long arg1)
        {
            return IExecute<long>("nextLong", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SplittableRandom.html#nextLong(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long NextLong(long arg0)
        {
            return IExecute<long>("nextLong", arg0);
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