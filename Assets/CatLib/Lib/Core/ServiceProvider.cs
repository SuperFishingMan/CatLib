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
 
using System;
using System.Collections;
using CatLib.API;

namespace CatLib
{
    /// <summary>
    /// 服务提供者
    /// </summary>
    public abstract class ServiceProvider
    {

        public virtual void Init() { }

        public virtual ProviderProcess ProviderProcess { get { return ProviderProcess.Normal; } }

        public virtual IEnumerator OnProviderProcess() { yield break; }

        public IApplication App { get { return CatLib.App.Instance; } }

        abstract public void Register();

    }

}