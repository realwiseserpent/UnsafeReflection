    String ctl = request.GetParameter("ctl");
    Type cmdClass = Type.GetType(ctl + "Command");
    Worker ao = (Worker) Activator.CreateInstance(cmdClass);
    ao.CheckAccessControl(request);
    ao.DoAction(request);