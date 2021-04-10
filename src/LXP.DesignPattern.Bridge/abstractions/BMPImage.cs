﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.Bridge.abstractions
{
    /// <summary>
    /// BMP 格式图像：扩充抽象类
    /// </summary>
    public class BMPImage : Image
    {
        public override void ParseFile(string fileName)
        {
            //模拟器解析 BMP 文件并获得一份像素矩阵对象 m
            Matrix m = new Matrix();
            imageImp.DoPaint(m);
            Console.WriteLine(fileName + ",格式为BMP");
        }
    }
}
