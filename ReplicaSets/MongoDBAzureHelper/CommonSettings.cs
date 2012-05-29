﻿/*
 * Copyright 2010-2012 10gen Inc.
 * file : CommonSettings.cs
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 * 
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
namespace MongoDB.Azure.Common
{
    using System;

    public static class CommonSettings
    {
        public const string MongodPortSetting = "MongodPort";
        public const string ReplicaSetNameSetting = "ReplicaSetName";
        public const string MongoDBWorkerRoleName = "ReplicaSetRole";
    }
}