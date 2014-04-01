package edu.lynchburg.students;

import android.os.Bundle;
import android.app.Activity;
import android.view.Menu;

public class MainClient extends Activity {

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		//Test #1
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main_client);
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		//Test #2
		getMenuInflater().inflate(R.menu.main_client, menu);
		return true;
	}

}
