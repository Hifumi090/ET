﻿namespace ET
{
    //方便统一管理日志输出
    public static class LubanLog
    {
        public static void Error(object config, object key)
        {
            Log.Error($"{config.GetType().Name} 配置错误，键 {key} 不存在");
        }
    }
}