package login.com;


import android.app.AlertDialog;
import android.content.Context;
/**
 * Dialog used to make notice
 * @author F
 */
public class DialogDemo
{
	// warning messsage box
	public static void builder(Context context, String title, String message)
	{
		AlertDialog.Builder builder = new AlertDialog.Builder(context);
		builder.setTitle(title);
		builder.setMessage(message);
		builder.setPositiveButton("Ok", null);
		builder.create();
		builder.show();
	}
}
