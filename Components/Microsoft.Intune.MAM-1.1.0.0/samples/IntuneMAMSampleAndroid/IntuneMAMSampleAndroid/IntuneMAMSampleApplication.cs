﻿//-----------------------------------------------------------------------
// <copyright file="IntuneMAMSampleApplication.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Microsoft.Intune.Mam.Client.App;
using Microsoft.Intune.Mam.Client.Notification;
using Microsoft.Intune.Mam.Policy.Notification;
using Java.Util.Logging;

namespace IntuneMAMSampleAndroid
{
    [Application]
    public class IntuneMAMSampleApplication : MAMApplication
    {
        /// <summary>
        /// This is necessary because of a leaky abstraction somewhere up the chain:
        /// http://stackoverflow.com/questions/10593022/monodroid-error-when-calling-constructor-of-custom-view-twodscrollview/10603714#10603714
        /// </summary>
        /// <param name="handle">Java reference</param>
        /// <param name="transfer">Ownership transfer</param>
        public IntuneMAMSampleApplication (IntPtr handle, JniHandleOwnership transfer)
            : base(handle, transfer)
        {
        }

        /// <summary>
        /// New abstract method that we need to override
        /// Documentation at https://microsoft.sharepoint.com/teams/Android_SSP/_layouts/15/WopiFrame2.aspx?sourcedoc=%7b56C60010-40D5-4487-BC70-21471C50D1DD%7d&file=Walled%20Garden%20API%20Guide.docx&action=default says:
        /// If your application does not call AuthenticationSettings.setSecretKey (or does not integrate ADAL at all), you may simply return null. 
        /// </summary>
        /// <returns>The ADAL key</returns>
        public override byte[] GetADALSecretKey()
        {
            return null;
        }
    }
}

