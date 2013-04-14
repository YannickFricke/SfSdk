﻿namespace SfSdk.ResponseData
{
    /// <summary>
    ///     A response.
    /// </summary>
    internal interface IResponse
    {
        /// <summary>
        ///     The response arguments.
        /// </summary>
        string[] Args { get; }
    }
}