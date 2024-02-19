﻿using GAAPICommon.Messages;

namespace GAServiceCodes.Architecture;

public static class ExtensionMethods
{
    public static ServiceCodeDefinition? GetDefinition(this IServiceCodeDictionary dictionary, ErrorCode errorCode)
    {
        ArgumentNullException.ThrowIfNull(dictionary);

        return dictionary.GetDefinition((int)errorCode);
    }
}