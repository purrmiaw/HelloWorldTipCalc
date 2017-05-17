package md5850bab2f9765eb6a620732f23247411d;


public class HomeView
	extends mvvmcross.droid.views.MvxActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("HelloWorld.UI.Android.Views.HomeView, HelloWorld.UI.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", HomeView.class, __md_methods);
	}


	public HomeView () throws java.lang.Throwable
	{
		super ();
		if (getClass () == HomeView.class)
			mono.android.TypeManager.Activate ("HelloWorld.UI.Android.Views.HomeView, HelloWorld.UI.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
