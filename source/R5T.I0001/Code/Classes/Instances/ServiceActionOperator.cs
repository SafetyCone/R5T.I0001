using System;


namespace R5T.I0001
{
	public class ServiceActionOperator : IServiceActionOperator
	{
		#region Infrastructure

	    public static IServiceActionOperator Instance { get; } = new ServiceActionOperator();

	    private ServiceActionOperator()
	    {
        }

	    #endregion
	}
}