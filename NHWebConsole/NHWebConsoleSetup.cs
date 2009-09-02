﻿#region license
// Copyright (c) 2009 Mauricio Scheffer
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//      http://www.apache.org/licenses/LICENSE-2.0
//  
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#endregion

using System;
using NHibernate;
using NHibernate.Cfg;

namespace NHWebConsole {
    public static class NHWebConsoleSetup {
        public static Func<ISession> OpenSession { get; set; }

        public static Func<ISessionFactory> SessionFactory { get; set; }

        public static Func<Configuration> Configuration { get; set; }

        public static bool DisposeSession = true;

        static NHWebConsoleSetup() {
            OpenSession = () => SessionFactory().OpenSession();

            SessionFactory = () => {
                throw new Exception("Define NHWebConsole.NHWebConsoleSetup.SessionFactory");
            };

            Configuration = () => {
                throw new Exception("Define NHWebConsole.NHWebConsoleSetup.Configuration");
            };
        }
    }
}