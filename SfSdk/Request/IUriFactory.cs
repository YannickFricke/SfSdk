﻿using System;

namespace SfSdk.Request
{
    internal interface IUriFactory
    {
        /// <summary>
        ///     The session ID.
        /// </summary>
        string SessionId { get; }

        /// <summary>
        ///     The server <see cref="Uri"/>.
        /// </summary>
        Uri ServerUri { get; }

        /// <summary>
        ///     The S&amp;F action.
        /// </summary>
        string Action { get; }

        /// <summary>
        ///     The required arguments for a certain S&amp;F action.
        /// </summary>
        string Args { get; }

        /// <summary>
        ///     The assembled request <see cref="Uri"/>.
        /// </summary>
        Uri RequestUri { get; }
    }
}