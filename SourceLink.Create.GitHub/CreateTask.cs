﻿namespace SourceLink.Create.GitHub
{
    public class CreateTask : GitCreateTask
    {
        public override string ConvertUrl(string origin)
        {
            return UrlConverter.Convert(origin);
        }
    }
}
