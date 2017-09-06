﻿/*
 * This file is part of the CatLib package.
 *
 * (c) Yu Bin <support@catlib.io>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * Document: http://catlib.io/
 */

namespace CatLib.API.Random
{
    /// <summary>
    /// 随机算法生成器
    /// </summary>
    public interface IRandomFactory
    {
        /// <summary>
        /// 生成随机算法
        /// </summary>
        /// <param name="type">算法类型</param>
        /// <returns>随机数算法</returns>
        IRandom Make(RandomTypes type = RandomTypes.MersenneTwister);

        /// <summary>
        /// 生成随机算法
        /// </summary>
        /// <returns>随机数算法</returns>
        IRandom Make(int seed, RandomTypes type = RandomTypes.MersenneTwister);

        /// <summary>
        /// 返回一个随机数
        /// </summary>
        /// <param name="type">使用的随机算法类型</param>
        /// <returns>随机数</returns>
        int Next(RandomTypes type = RandomTypes.MersenneTwister);

        /// <summary>
        /// 返回一个随机数
        /// </summary>
        /// <param name="minValue">最小值</param>
        /// <param name="type">使用的随机算法类型</param>
        /// <returns>随机数</returns>
        int Next(int minValue , RandomTypes type = RandomTypes.MersenneTwister);

        /// <summary>
        /// 返回一个随机数
        /// </summary>
        /// <param name="minValue">最小值</param>
        /// <param name="maxValue">最大值</param>
        /// <param name="type">使用的随机算法类型</param>
        /// <returns>随机数</returns>
        int Next(int minValue, int maxValue, RandomTypes type = RandomTypes.MersenneTwister);

        /// <summary>
        /// 生成随机数填充流
        /// </summary>
        /// <param name="buffer">流</param>
        /// <param name="type">使用的随机算法类型</param>
        void NextBytes(byte[] buffer, RandomTypes type = RandomTypes.MersenneTwister);

        /// <summary>
        /// 返回一个介于0到1之间的随机数
        /// </summary>
        /// <param name="type">使用的随机算法类型</param>
        /// <returns>随机数</returns>
        double NextDouble(RandomTypes type = RandomTypes.MersenneTwister);
    }
}
