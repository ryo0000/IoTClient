﻿using IoTClient.Enums;
using IoTClient.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace IoTClient.Interfaces
{
    /// <summary>
    /// 以太网形式
    /// </summary>
    public interface IEthernetClient
    {
        /// <summary>
        /// 版本
        /// </summary>
        string Version { get; }
        /// <summary>
        /// IPEndPoint
        /// </summary>
        IPEndPoint IpAndPoint { get; }
        /// <summary>
        /// 是否是连接的
        /// </summary>
        bool Connected { get; }

        /// <summary>
        /// 警告日志委托
        /// 为了可用性，会对异常网络进行重试。此类日志通过委托接口给出去。
        /// </summary>
        LoggerDelegate WarningLog { get; set; }

        /// <summary>
        /// 打开连接（如果已经是连接状态会先关闭再打开）
        /// </summary>
        /// <returns></returns>
        Result Open();

        /// <summary>
        /// 关闭连接
        /// </summary>
        /// <returns></returns>
        Result Close();

        #region Read 

        /// <summary>
        /// 分批读取
        /// </summary>
        /// <param name="addresses">地址集合</param>
        /// <param name="batchNumber">批量读取数量</param>
        /// <returns></returns>
        Result<Dictionary<string, object>> BatchRead(Dictionary<string, DataTypeEnum> addresses, int batchNumber);

        /// <summary>
        /// 读取数据
        /// </summary>
        /// <param name="address">地址</param>
        /// <param name="length"></param>
        /// <param name="isBit"></param>
        /// <returns></returns>
        //Result<byte[]> Read(string address, ushort length, bool isBit = false, bool setEndian = true);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        Result<byte> ReadByte(string address);

        /// <summary>
        /// 读取Boolean
        /// </summary>
        /// <param name="address">地址</param>
        /// <returns></returns>
        Result<bool> ReadBoolean(string address);

        /// <summary>
        /// 读取UInt16
        /// </summary>
        /// <param name="address">地址</param>
        /// <returns></returns>
        Result<ushort> ReadUInt16(string address);

        /// <summary>
        /// 读取Int16
        /// </summary>
        /// <param name="address">地址</param>
        /// <returns></returns>
        Result<short> ReadInt16(string address);

        /// <summary>
        /// 读取UInt32
        /// </summary>
        /// <param name="address">地址</param>
        /// <returns></returns>
        Result<uint> ReadUInt32(string address);

        /// <summary>
        /// 读取Int32
        /// </summary>
        /// <param name="address">地址</param>
        /// <returns></returns>
        Result<int> ReadInt32(string address);

        /// <summary>
        /// 读取UInt64
        /// </summary>
        /// <param name="address">地址</param>
        /// <returns></returns>
        Result<ulong> ReadUInt64(string address);

        /// <summary>
        /// 读取Int64
        /// </summary>
        /// <param name="address">地址</param>
        /// <returns></returns>
        Result<long> ReadInt64(string address);

        /// <summary>
        /// 读取Float
        /// </summary>
        /// <param name="address">地址</param>
        /// <returns></returns>
        Result<float> ReadFloat(string address);

        /// <summary>
        /// 读取Double
        /// </summary>
        /// <param name="address">地址</param>
        /// <returns></returns>
        Result<double> ReadDouble(string address);

        /// <summary>
        /// 读取String
        /// </summary>
        /// <param name="address">地址</param>
        /// <returns></returns>
        Result<string> ReadString(string address);

        #endregion

        #region Write

        /// <summary>
        /// 分批写入 
        /// </summary>
        /// <param name="addresses">地址集合</param>
        /// <param name="batchNumber">批量读取数量</param>
        /// <returns></returns>
        Result BatchWrite(Dictionary<string, object> addresses, int batchNumber);

        /// <summary>
        /// 写入数据
        /// </summary>
        /// <param name="address">地址</param>
        /// <param name="data">值</param>
        /// <param name="isBit">值</param>
        /// <returns></returns>
        //Result Write(string address, byte[] data, bool isBit = false);

        /// <summary>
        /// 写入数据
        /// </summary>
        /// <param name="address">地址</param>
        /// <param name="value">值</param>
        /// <returns></returns>
        Result Write(string address, byte value);

        /// <summary>
        /// 写入数据
        /// </summary>
        /// <param name="address">地址</param>
        /// <param name="value">值</param>
        /// <returns></returns>
        Result Write(string address, bool value);

        /// <summary>
        /// 写入数据
        /// </summary>
        /// <param name="address">地址</param>
        /// <param name="value">值</param>
        /// <returns></returns>
        Result Write(string address, sbyte value);

        /// <summary>
        /// 写入数据
        /// </summary>
        /// <param name="address">地址</param>
        /// <param name="value">值</param>
        /// <returns></returns>
        Result Write(string address, ushort value);

        /// <summary>
        /// 写入数据
        /// </summary>
        /// <param name="address">地址</param>
        /// <param name="value">值</param>
        /// <returns></returns>
        Result Write(string address, short value);

        /// <summary>
        /// 写入数据
        /// </summary>
        /// <param name="address">地址</param>
        /// <param name="value">值</param>
        /// <returns></returns>
        Result Write(string address, uint value);

        /// <summary>
        /// 写入数据
        /// </summary>
        /// <param name="address">地址</param>
        /// <param name="value">值</param>
        /// <returns></returns>
        Result Write(string address, int value);

        /// <summary>
        /// 写入数据
        /// </summary>
        /// <param name="address">地址</param>
        /// <param name="value">值</param>
        /// <returns></returns>
        Result Write(string address, ulong value);

        /// <summary>
        /// 写入数据
        /// </summary>
        /// <param name="address">地址</param>
        /// <param name="value">值</param>
        /// <returns></returns>
        Result Write(string address, long value);

        /// <summary>
        /// 写入数据
        /// </summary>
        /// <param name="address">地址</param>
        /// <param name="value">值</param>
        /// <returns></returns>
        Result Write(string address, float value);

        /// <summary>
        /// 写入数据
        /// </summary>
        /// <param name="address">地址</param>
        /// <param name="value">值</param>
        /// <returns></returns>
        Result Write(string address, double value);

        /// <summary>
        /// 写入数据
        /// </summary>
        /// <param name="address">地址</param>
        /// <param name="value">值</param>
        /// <returns></returns>
        Result Write(string address, string value);
        #endregion

    }
}
