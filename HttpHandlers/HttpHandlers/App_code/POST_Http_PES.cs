﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HttpHandlers.App_code
{
    public class POST_Http_PES : IHttpHandler
    {
        public bool IsReusable
        {
            get
            {
                return true;
            }
        }

        public void ProcessRequest(HttpContext context)
        {
            context.Response.AppendHeader("Access-Control-Allow-Origin", "*");
            context.Response.Write(String.Format("POST-Http-PES: ParmA = {0}, ParmB = {1}", context.Request.Params.Get("ParmA"), context.Request.Params.Get("ParmB")));
        }
    }
}