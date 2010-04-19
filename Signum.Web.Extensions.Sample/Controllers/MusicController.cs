﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.UI;
using Signum.Test;
using Signum.Web.Operations;
using Signum.Engine;
using Signum.Entities;
using Signum.Engine.Operations;
using Signum.Test.Extensions;

namespace Signum.Web.Extensions.Sample
{
    [HandleError]
    public class MusicController : Controller
    {
        public ActionResult CreateAlbumFromBand(string prefix)
        {
            BandDN band = Navigator.ExtractEntity<BandDN>(this);

            AlbumFromBandModel model = new AlbumFromBandModel(band.ToLite());

            JsValidatorOptions voptions = new JsValidatorOptions
            {
                Prefix = prefix,
                Type = typeof(AlbumFromBandModel).Name,
                OnSuccess = "function(){ " + JsOperationBase.Execute(new JsOperationExecutor(new JsOperationOptions { Prefix = prefix, NavigateOnSuccess = true, ControllerUrl = "Music/CreateAlbumFromBandOnOk" })).ToJS() + "; }"
            };
            
            ViewData[ViewDataKeys.WriteSFInfo] = true;
            ViewData[ViewDataKeys.OnOk] = "ValidatePartial(" + voptions.ToJS() + ");";
            
            return Navigator.PopupView(this, model, prefix);
        }

        public ContentResult CreateAlbumFromBandOnOk(string prefix)
        {
            MappingContext<AlbumFromBandModel> context = Navigator.ExtractEntity<AlbumFromBandModel>(this, prefix).ApplyChanges(this.ControllerContext, prefix, true).ValidateGlobal();

            AlbumDN newAlbum = context.Value.Band.ConstructFromLite<AlbumDN>(AlbumOperation.CreateFromBand, new object[] { context.Value.Name, context.Value.Year, context.Value.Label });

            return Content(Navigator.ViewRoute(typeof(AlbumDN), newAlbum.Id));
        }
    }
}
