
// This file has been generated by the GUI designer. Do not modify.

public partial class frmMain
{
	private global::Gtk.UIManager UIManager;
	
	private global::Gtk.Action HelpAction;
	
	private global::Gtk.Action dialogInfoAction;
	
	private global::Gtk.Action FileAction;
	
	private global::Gtk.Action quitAction;
	
	private global::Gtk.VBox vboxApplication;
	
	private global::Gtk.MenuBar menuMain;
	
	private global::Gtk.HBox hboxBody;
	
	private global::Gtk.Notebook noteMain;
	
	private global::Gtk.VBox vboxPageHome;
	
	private global::Gtk.Label lblHomeInfo;
	
	private global::Gtk.CheckButton chkMostRecentlyUsed;
	
	private global::Gtk.CheckButton chkCommandLineHistory;
	
	private global::Gtk.CheckButton chkWastebasket;
	
	private global::Gtk.CheckButton chkImageThumbnails;
	
	private global::Gtk.Label lblPageHome;
	
	private global::Gtk.Label lblPageApplications;
	
	private global::Gtk.ScrolledWindow GtkScrolledWindow;
	
	private global::Gtk.TextView txtConsole;
	
	private global::Gtk.HBox hboxFooter;
	
	private global::Gtk.Button btnClean;
	
	private global::Gtk.HSeparator hseparator1;
	
	private global::Gtk.Button btnReset;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget frmMain
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.HelpAction = new global::Gtk.Action ("HelpAction", global::Mono.Unix.Catalog.GetString ("_Help"), null, null);
		this.HelpAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_Help");
		w1.Add (this.HelpAction, null);
		this.dialogInfoAction = new global::Gtk.Action ("dialogInfoAction", global::Mono.Unix.Catalog.GetString ("_About"), null, "gtk-dialog-info");
		this.dialogInfoAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_About");
		w1.Add (this.dialogInfoAction, null);
		this.FileAction = new global::Gtk.Action ("FileAction", global::Mono.Unix.Catalog.GetString ("_File"), null, null);
		this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_File");
		w1.Add (this.FileAction, null);
		this.quitAction = new global::Gtk.Action ("quitAction", global::Mono.Unix.Catalog.GetString ("Exit"), null, "gtk-quit");
		this.quitAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("E_xit");
		w1.Add (this.quitAction, null);
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "frmMain";
		this.Title = global::Mono.Unix.Catalog.GetString ("Linux Deletion Utility");
		this.Icon = global::Stetic.IconLoader.LoadIcon (this, "gtk-execute", global::Gtk.IconSize.Menu);
		this.WindowPosition = ((global::Gtk.WindowPosition)(1));
		this.DefaultWidth = 600;
		this.DefaultHeight = 400;
		// Container child frmMain.Gtk.Container+ContainerChild
		this.vboxApplication = new global::Gtk.VBox ();
		this.vboxApplication.Name = "vboxApplication";
		this.vboxApplication.Spacing = 6;
		this.vboxApplication.BorderWidth = ((uint)(2));
		// Container child vboxApplication.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><menubar name='menuMain'><menu name='FileAction' action='FileAction'><menuitem name='quitAction' action='quitAction'/></menu><menu name='HelpAction' action='HelpAction'><menuitem name='dialogInfoAction' action='dialogInfoAction'/></menu></menubar></ui>");
		this.menuMain = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menuMain")));
		this.menuMain.Name = "menuMain";
		this.vboxApplication.Add (this.menuMain);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vboxApplication [this.menuMain]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vboxApplication.Gtk.Box+BoxChild
		this.hboxBody = new global::Gtk.HBox ();
		this.hboxBody.Name = "hboxBody";
		this.hboxBody.Homogeneous = true;
		this.hboxBody.Spacing = 6;
		this.hboxBody.BorderWidth = ((uint)(2));
		// Container child hboxBody.Gtk.Box+BoxChild
		this.noteMain = new global::Gtk.Notebook ();
		this.noteMain.CanFocus = true;
		this.noteMain.Name = "noteMain";
		this.noteMain.CurrentPage = 0;
		this.noteMain.ShowBorder = false;
		// Container child noteMain.Gtk.Notebook+NotebookChild
		this.vboxPageHome = new global::Gtk.VBox ();
		this.vboxPageHome.Name = "vboxPageHome";
		this.vboxPageHome.Spacing = 8;
		this.vboxPageHome.BorderWidth = ((uint)(2));
		// Container child vboxPageHome.Gtk.Box+BoxChild
		this.lblHomeInfo = new global::Gtk.Label ();
		this.lblHomeInfo.Name = "lblHomeInfo";
		this.lblHomeInfo.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Home Folder Items</b>");
		this.lblHomeInfo.UseMarkup = true;
		this.vboxPageHome.Add (this.lblHomeInfo);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vboxPageHome [this.lblHomeInfo]));
		w3.Position = 1;
		w3.Expand = false;
		w3.Fill = false;
		w3.Padding = ((uint)(8));
		// Container child vboxPageHome.Gtk.Box+BoxChild
		this.chkMostRecentlyUsed = new global::Gtk.CheckButton ();
		this.chkMostRecentlyUsed.CanFocus = true;
		this.chkMostRecentlyUsed.Name = "chkMostRecentlyUsed";
		this.chkMostRecentlyUsed.Label = global::Mono.Unix.Catalog.GetString ("Most Recently Used Files List");
		this.chkMostRecentlyUsed.DrawIndicator = true;
		this.chkMostRecentlyUsed.UseUnderline = true;
		this.vboxPageHome.Add (this.chkMostRecentlyUsed);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vboxPageHome [this.chkMostRecentlyUsed]));
		w4.Position = 2;
		w4.Expand = false;
		w4.Fill = false;
		// Container child vboxPageHome.Gtk.Box+BoxChild
		this.chkCommandLineHistory = new global::Gtk.CheckButton ();
		this.chkCommandLineHistory.CanFocus = true;
		this.chkCommandLineHistory.Name = "chkCommandLineHistory";
		this.chkCommandLineHistory.Label = global::Mono.Unix.Catalog.GetString ("Command Line History");
		this.chkCommandLineHistory.DrawIndicator = true;
		this.chkCommandLineHistory.UseUnderline = true;
		this.vboxPageHome.Add (this.chkCommandLineHistory);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vboxPageHome [this.chkCommandLineHistory]));
		w5.Position = 3;
		w5.Expand = false;
		w5.Fill = false;
		// Container child vboxPageHome.Gtk.Box+BoxChild
		this.chkWastebasket = new global::Gtk.CheckButton ();
		this.chkWastebasket.CanFocus = true;
		this.chkWastebasket.Name = "chkWastebasket";
		this.chkWastebasket.Label = global::Mono.Unix.Catalog.GetString ("Wastebasket / Trash Contents");
		this.chkWastebasket.DrawIndicator = true;
		this.chkWastebasket.UseUnderline = true;
		this.vboxPageHome.Add (this.chkWastebasket);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vboxPageHome [this.chkWastebasket]));
		w6.Position = 4;
		w6.Expand = false;
		w6.Fill = false;
		// Container child vboxPageHome.Gtk.Box+BoxChild
		this.chkImageThumbnails = new global::Gtk.CheckButton ();
		this.chkImageThumbnails.CanFocus = true;
		this.chkImageThumbnails.Name = "chkImageThumbnails";
		this.chkImageThumbnails.Label = global::Mono.Unix.Catalog.GetString ("Image Thumbnail Cache");
		this.chkImageThumbnails.DrawIndicator = true;
		this.chkImageThumbnails.UseUnderline = true;
		this.vboxPageHome.Add (this.chkImageThumbnails);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vboxPageHome [this.chkImageThumbnails]));
		w7.Position = 5;
		w7.Expand = false;
		w7.Fill = false;
		this.noteMain.Add (this.vboxPageHome);
		// Notebook tab
		this.lblPageHome = new global::Gtk.Label ();
		this.lblPageHome.Name = "lblPageHome";
		this.lblPageHome.LabelProp = global::Mono.Unix.Catalog.GetString ("Home Folder");
		this.noteMain.SetTabLabel (this.vboxPageHome, this.lblPageHome);
		this.lblPageHome.ShowAll ();
		// Notebook tab
		global::Gtk.Label w9 = new global::Gtk.Label ();
		w9.Visible = true;
		this.noteMain.Add (w9);
		this.lblPageApplications = new global::Gtk.Label ();
		this.lblPageApplications.Name = "lblPageApplications";
		this.lblPageApplications.LabelProp = global::Mono.Unix.Catalog.GetString ("Applications");
		this.noteMain.SetTabLabel (w9, this.lblPageApplications);
		this.lblPageApplications.ShowAll ();
		this.hboxBody.Add (this.noteMain);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hboxBody [this.noteMain]));
		w10.Position = 0;
		// Container child hboxBody.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.txtConsole = new global::Gtk.TextView ();
		this.txtConsole.CanFocus = true;
		this.txtConsole.Name = "txtConsole";
		this.txtConsole.Editable = false;
		this.txtConsole.CursorVisible = false;
		this.txtConsole.Overwrite = true;
		this.txtConsole.WrapMode = ((global::Gtk.WrapMode)(2));
		this.txtConsole.LeftMargin = 4;
		this.txtConsole.RightMargin = 4;
		this.GtkScrolledWindow.Add (this.txtConsole);
		this.hboxBody.Add (this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hboxBody [this.GtkScrolledWindow]));
		w12.Position = 1;
		this.vboxApplication.Add (this.hboxBody);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vboxApplication [this.hboxBody]));
		w13.Position = 1;
		// Container child vboxApplication.Gtk.Box+BoxChild
		this.hboxFooter = new global::Gtk.HBox ();
		this.hboxFooter.Name = "hboxFooter";
		this.hboxFooter.Spacing = 6;
		this.hboxFooter.BorderWidth = ((uint)(2));
		// Container child hboxFooter.Gtk.Box+BoxChild
		this.btnClean = new global::Gtk.Button ();
		this.btnClean.CanFocus = true;
		this.btnClean.Name = "btnClean";
		this.btnClean.UseUnderline = true;
		this.btnClean.Label = global::Mono.Unix.Catalog.GetString ("_Start Cleaning");
		this.hboxFooter.Add (this.btnClean);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hboxFooter [this.btnClean]));
		w14.Position = 0;
		w14.Expand = false;
		w14.Fill = false;
		// Container child hboxFooter.Gtk.Box+BoxChild
		this.hseparator1 = new global::Gtk.HSeparator ();
		this.hseparator1.Name = "hseparator1";
		this.hboxFooter.Add (this.hseparator1);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hboxFooter [this.hseparator1]));
		w15.Position = 1;
		// Container child hboxFooter.Gtk.Box+BoxChild
		this.btnReset = new global::Gtk.Button ();
		this.btnReset.CanFocus = true;
		this.btnReset.Name = "btnReset";
		this.btnReset.UseUnderline = true;
		this.btnReset.Label = global::Mono.Unix.Catalog.GetString ("_Reset");
		this.hboxFooter.Add (this.btnReset);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hboxFooter [this.btnReset]));
		w16.Position = 2;
		w16.Expand = false;
		w16.Fill = false;
		this.vboxApplication.Add (this.hboxFooter);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vboxApplication [this.hboxFooter]));
		w17.Position = 2;
		w17.Expand = false;
		w17.Fill = false;
		this.Add (this.vboxApplication);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.dialogInfoAction.Activated += new global::System.EventHandler (this.menuAbout_Click);
		this.quitAction.Activated += new global::System.EventHandler (this.menuExit_Click);
		this.btnClean.Clicked += new global::System.EventHandler (this.btnClean_Click);
		this.btnReset.Clicked += new global::System.EventHandler (this.btnReset_Click);
	}
}
