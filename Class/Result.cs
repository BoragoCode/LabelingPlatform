﻿/*
k-Space Astronauts labeling platform
    (c) 2016 under Apache 2.0 license 
    Thomas Kuestner, Martin Schwartz, Philip Wolf
    Please refer to https://sites.google.com/site/kspaceastronauts/iqa/labelingplatform for more information
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabelingFramework.Class
{
    public class Result
    {
        public  bool result { get; set; }
        public string Message { get; set; }

        public Result()
        {
            result = false;
            Message = string.Empty;
        }
    }
}