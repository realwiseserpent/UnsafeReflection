    String ctl = request.GetParameter("ctl");
    Type cmdClass = Type.GetType(ctl + "Command");
	if(!(cmdClass.IsSubclassOf(typeof(Worker)) || cmdClass.IsEquivalentTo(typeof(Worker))))
		throw new Exception("some text");
    Worker ao = (Worker) Activator.CreateInstance(cmdClass);
    ao.CheckAccessControl(request);
    ao.DoAction(request);