// <copyright file="LogInProcessFactory.cs">Copyright ©  2018</copyright>

using System;
using Microsoft.Pex.Framework;

/// <summary>A factory for LogInProcess instances</summary>
public static partial class LogInProcessFactory
{
    /// <summary>A factory for LogInProcess instances</summary>
    [PexFactoryMethod(typeof(global::LogInProcess))]
    public static global::LogInProcess Create()
    {
        global::LogInProcess logInProcess = new global::LogInProcess();
        return logInProcess;

        // TODO: Edit factory method of LogInProcess
        // This method should be able to configure the object in all possible ways.
        // Add as many parameters as needed,
        // and assign their values to each field by using the API.
    }
}
