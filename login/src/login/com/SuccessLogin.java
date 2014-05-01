package login.com;

import android.app.Activity;
import android.content.Context;
import android.content.BroadcastReceiver;
import android.content.Intent;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.net.ConnectivityManager;
import android.net.NetworkInfo;
import android.os.Bundle;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.content.Intent;
import android.content.IntentFilter;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;
import android.net.wifi.ScanResult;
import android.net.wifi.WifiManager;
import android.util.Log;
import android.view.View;
import java.util.List;

/** 
* successful login page
* FU
*/


public class SuccessLogin extends Activity implements OnClickListener{
	private transient WifiManager wifi;
	private transient BroadcastReceiver receiver;
	private transient StringBuilder status = new StringBuilder();
	Button exit;
	Button scan;
	TextView wifiStre;

    /** Called when the activity is first created. */
	@Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.success); 
        	exit = (Button)findViewById(R.id.exit);
          	exit.setOnClickListener(this);
        	scan = (Button)findViewById(R.id.scan);
        	scan.setOnClickListener(this);
        	wifiStre = (TextView)findViewById(R.id.wifiStre);
        	
	}
	

	@Override
	  public void onClick (View v) {
			// TODO Auto-generated method stub
				int id = v.getId();
				
			    /**
				* click to exit(back to login page)
				*/
				if(id == R.id.exit)
				 { 
					 Intent intent = new Intent();
					 intent.setClass(SuccessLogin.this, Login.class);
					 startActivity(intent);
					 Toast.makeText(SuccessLogin.this, "Successful exit", Toast.LENGTH_SHORT).show(); 
			 	}
			    /**
				* scan button
				*/
				else if(id == R.id.scan)
				 { 
					 Intent intent = new Intent();
					 intent.setClass(SuccessLogin.this, Login.class);
					 startActivity(intent);
					 

						wifi.setWifiEnabled(true);
						Toast.makeText(getApplicationContext(), "Start Scan.",
							Toast.LENGTH_LONG).show();
						Log.d("WifiInfo", "onClick() wifi.startScan()");
						wifi.startScan();
						wifi = (WifiManager) getSystemService(Context.WIFI_SERVICE);
						wifi.setWifiEnabled(true);
						if (receiver == null) {
							receiver = new WiFiScanReceiver();

						registerReceiver(receiver, new IntentFilter(
								WifiManager.SCAN_RESULTS_AVAILABLE_ACTION));
						Log.d("WifiInfo", "onCreate()");
					}
			 	}
			}
	
    private boolean isWifiConnected(){
    //	ConnectivityManager cm = (ConnectivityManager) getSystemService(Context.CONNECTIVITY_SERVICE);
    //	if (cm != null){
    //		NetworkInfo wifiInfo = cm.getActiveNetworkInfo();
    //			if (wifiInfo!=null && wifiInfo.getType() == ConnectivityManager.TYPE_WIFI ){
    //
    //					return true;
    //			}
    //	}
    	return false;
    }
    
	/*
	 * Show the all wifi information that phone get
	 * */
	class WiFiScanReceiver extends BroadcastReceiver {

		@Override
		public void onReceive(final Context context, final Intent intent) {
			status = new StringBuilder();
			final List<ScanResult> results = wifi.getScanResults();
			for (int i = 0; i < results.size(); i++) {
				status.append(results.get(i).toString());
				status.append("\n");
			}
			wifiStre.setText(status);
		}

	}
    
}
    

