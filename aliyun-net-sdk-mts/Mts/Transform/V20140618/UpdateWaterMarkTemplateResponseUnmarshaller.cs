/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Mts.Model.V20140618;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class UpdateWaterMarkTemplateResponseUnmarshaller
    {
        public static UpdateWaterMarkTemplateResponse Unmarshall(UnmarshallerContext context)
        {
			UpdateWaterMarkTemplateResponse updateWaterMarkTemplateResponse = new UpdateWaterMarkTemplateResponse();

			updateWaterMarkTemplateResponse.HttpResponse = context.HttpResponse;
			updateWaterMarkTemplateResponse.RequestId = context.StringValue("UpdateWaterMarkTemplate.RequestId");

			UpdateWaterMarkTemplateResponse.UpdateWaterMarkTemplate_WaterMarkTemplate waterMarkTemplate = new UpdateWaterMarkTemplateResponse.UpdateWaterMarkTemplate_WaterMarkTemplate();
			waterMarkTemplate.Id = context.StringValue("UpdateWaterMarkTemplate.WaterMarkTemplate.Id");
			waterMarkTemplate.Name = context.StringValue("UpdateWaterMarkTemplate.WaterMarkTemplate.Name");
			waterMarkTemplate.Width = context.StringValue("UpdateWaterMarkTemplate.WaterMarkTemplate.Width");
			waterMarkTemplate.Height = context.StringValue("UpdateWaterMarkTemplate.WaterMarkTemplate.Height");
			waterMarkTemplate.Dx = context.StringValue("UpdateWaterMarkTemplate.WaterMarkTemplate.Dx");
			waterMarkTemplate.Dy = context.StringValue("UpdateWaterMarkTemplate.WaterMarkTemplate.Dy");
			waterMarkTemplate.ReferPos = context.StringValue("UpdateWaterMarkTemplate.WaterMarkTemplate.ReferPos");
			waterMarkTemplate.Type = context.StringValue("UpdateWaterMarkTemplate.WaterMarkTemplate.Type");
			waterMarkTemplate.State = context.StringValue("UpdateWaterMarkTemplate.WaterMarkTemplate.State");

			UpdateWaterMarkTemplateResponse.UpdateWaterMarkTemplate_WaterMarkTemplate.UpdateWaterMarkTemplate_Timeline timeline = new UpdateWaterMarkTemplateResponse.UpdateWaterMarkTemplate_WaterMarkTemplate.UpdateWaterMarkTemplate_Timeline();
			timeline.Start = context.StringValue("UpdateWaterMarkTemplate.WaterMarkTemplate.Timeline.Start");
			timeline.Duration = context.StringValue("UpdateWaterMarkTemplate.WaterMarkTemplate.Timeline.Duration");
			waterMarkTemplate.Timeline = timeline;

			UpdateWaterMarkTemplateResponse.UpdateWaterMarkTemplate_WaterMarkTemplate.UpdateWaterMarkTemplate_RatioRefer ratioRefer = new UpdateWaterMarkTemplateResponse.UpdateWaterMarkTemplate_WaterMarkTemplate.UpdateWaterMarkTemplate_RatioRefer();
			ratioRefer.Dx = context.StringValue("UpdateWaterMarkTemplate.WaterMarkTemplate.RatioRefer.Dx");
			ratioRefer.Dy = context.StringValue("UpdateWaterMarkTemplate.WaterMarkTemplate.RatioRefer.Dy");
			ratioRefer.Width = context.StringValue("UpdateWaterMarkTemplate.WaterMarkTemplate.RatioRefer.Width");
			ratioRefer.Height = context.StringValue("UpdateWaterMarkTemplate.WaterMarkTemplate.RatioRefer.Height");
			waterMarkTemplate.RatioRefer = ratioRefer;
			updateWaterMarkTemplateResponse.WaterMarkTemplate = waterMarkTemplate;
        
			return updateWaterMarkTemplateResponse;
        }
    }
}
