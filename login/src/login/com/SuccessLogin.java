package login.com;

import android.app.Activity;
import android.content.Intent;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;



public class SuccessLogin extends Activity implements OnClickListener{
	Button exit;
    /** Called when the activity is first created. */
	@Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.success); 
        	exit = (Button)findViewById(R.id.exit);
   //     back2.setOnClickListener((OnClickListener) this);
        	
        	exit.setOnClickListener(this);
	}
	
    /**
	* click to exit(back to login page)
	*/
	@Override
	  public void onClick (View v) {
			// TODO Auto-generated method stub
				int id = v.getId();
				if(id == R.id.exit)
				 { 
					 Intent intent = new Intent();
					 intent.setClass(SuccessLogin.this, Login.class);
					 startActivity(intent);
					 Toast.makeText(SuccessLogin.this, "Successful exit", Toast.LENGTH_SHORT).show();
			 	}
			}
		}
    

