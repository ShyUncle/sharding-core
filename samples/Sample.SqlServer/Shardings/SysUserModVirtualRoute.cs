using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Sample.SqlServer.Domain.Entities;
using ShardingCore.Core.VirtualRoutes;
using ShardingCore.VirtualRoutes;
using ShardingCore.VirtualRoutes.Mods;

namespace Sample.SqlServer.Shardings
{
/*
* @Author: xjm
* @Description:
* @Date: Thursday, 14 January 2021 15:39:27
* @Email: 326308290@qq.com
*/
    public class SysUserModVirtualRoute : AbstractSimpleShardingModKeyStringVirtualRoute<SysUserMod>
    {
        public SysUserModVirtualRoute() : base(3)
        {
        }
    }
}