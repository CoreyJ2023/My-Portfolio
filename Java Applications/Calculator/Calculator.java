/*
	Chapter 6: Java Calculator
	Programmer: Corey Jenkins
	Date: July 12, 2016
	Filename: Calculator.java
	Purpose: Creating a calculator with a menu
*/

import java.awt.*;
import java.awt.event.*;
import java.awt.datatransfer.*;
import java.text.DecimalFormat;
import javax.swing.JOptionPane;

public class Calculator extends Frame implements ActionListener {
	private Button keys[];
	private Panel keypad;
	private TextField lcd;
	private double opl;
	private boolean first;
	private boolean foundKey;
	private boolean clearText;
	private int lastOp;
	private DecimalFormat calcPattern;

	public Calculator() {
		MenuBar mnuBar = new MenuBar();
		setMenuBar(mnuBar);

		Menu mnuFile = new Menu("File", true);
		mnuBar.add(mnuFile);
		MenuItem mnuFileExit = new MenuItem("Exit");
		mnuFile.add(mnuFileExit);

		Menu mnuEdit = new Menu("Edit", true);
		mnuBar.add(mnuEdit);
		MenuItem mnuEditClear = new MenuItem("Clear");
		mnuEdit.add(mnuEditClear);
		mnuEdit.insertSeparator(1);
		MenuItem mnuEditCopy = new MenuItem("Copy");
		mnuEdit.add(mnuEditCopy);
		MenuItem mnuEditPaste = new MenuItem("Paste");
		mnuEdit.add(mnuEditPaste);

		Menu mnuAbout = new Menu("About", true);
		mnuBar.add(mnuAbout);
		MenuItem mnuAboutCalculator = new MenuItem("About Calculator");
		mnuAbout.add(mnuAboutCalculator);

		mnuFileExit.addActionListener(this);
		mnuEditClear.addActionListener(this);
		mnuEditCopy.addActionListener(this);
		mnuEditPaste.addActionListener(this);
		mnuAboutCalculator.addActionListener(this);

		mnuFileExit.setActionCommand("Exit");
		mnuEditClear.setActionCommand("Clear");
		mnuEditCopy.setActionCommand("Copy");
		mnuEditPaste.setActionCommand("Paste");
		mnuAboutCalculator.setActionCommand("About");

		lcd = new TextField(20);
		lcd.setEditable(false);
		keypad = new Panel();
		keys = new Button[16];
		first = true;
		opl = 0.0;
		clearText = true;
		lastOp = 0;
		calcPattern = new DecimalFormat("########.########");

		for (int i = 0; i <= 9; i++)
			keys[i] = new Button(String.valueOf(i));

		keys[10] = new Button("/");
		keys[11] = new Button("*");
		keys[12] = new Button("-");
		keys[13] = new Button("+");
		keys[14] = new Button("=");
		keys[15] = new Button(".");

		setLayout(new BorderLayout());
		keypad.setLayout(new GridLayout(4, 4, 10, 10));

		for (int i = 7; i <= 10; i++)
			keypad.add(keys[i]);

		for (int i = 4; i <= 6; i++)
			keypad.add(keys[i]);

		keypad.add(keys[11]);

		for (int i = 1; i <= 3; i++)
			keypad.add(keys[i]);

		keypad.add(keys[12]);

		keypad.add(keys[0]);

		for (int i = 15; i >= 13; i--)
			keypad.add(keys[i]);

		for (int i = 0; i < keys.length; i++)
			keys[i].addActionListener(this);

		add(lcd, BorderLayout.NORTH);
		add(keypad, BorderLayout.CENTER);

		addWindowListener(
				new WindowAdapter() {
					public void windowClosing(WindowEvent e) {
						System.exit(0);
					}
				});
	}

	public void actionPerformed(ActionEvent e) {
		String arg = e.getActionCommand();
		if (arg == "Exit")
			System.exit(0);

		if (arg == "Clear") {
			clearText = true;
			first = true;
			opl = 0.0;
			lcd.setText("");
			lcd.requestFocus();
		}

		if (arg == "Copy") {
			Clipboard cb = Toolkit.getDefaultToolkit().getSystemClipboard();
			StringSelection contents = new StringSelection(lcd.getText());
			cb.setContents(contents, null);
		}

		if (arg == "Paste") {
			Clipboard cb = Toolkit.getDefaultToolkit().getSystemClipboard();
			Transferable content = cb.getContents(this);
			try {
				String s = (String) content.getTransferData(DataFlavor.stringFlavor);
				lcd.setText(calcPattern.format(Double.parseDouble(s)));
			} catch (Throwable exc) {
				lcd.setText("");
			}
		}

		if (arg == "About") {
			String message = "Calculator ver. 1.0/nOpenExhibit Software\nCopyright 2007\nAll rights reserved";
			JOptionPane.showMessageDialog(null, message, "About Calculator", JOptionPane.INFORMATION_MESSAGE);
		}

		foundKey = false;

		for (int i = 0; i < keys.length && !foundKey; i++) {
			if (e.getSource() == keys[i]) {
				foundKey = true;
				switch (i) {
					case 0:
					case 1:
					case 2:
					case 3:
					case 4:
					case 5:
					case 6:
					case 7:
					case 8:
					case 9:
					case 15:
						if (clearText) {
							lcd.setText("");
							clearText = false;
						}
						lcd.setText(lcd.getText() + keys[i].getLabel());
						break;

					case 10:
					case 11:
					case 12:
					case 13:
					case 14:
						clearText = true;

						if (first) {
							if (lcd.getText().length() == 0)
								opl = 0.0;
							else
								opl = Double.parseDouble(lcd.getText());

							first = false;
							clearText = true;
							lastOp = i;
						} else {
							switch (lastOp) {
								case 10:
									opl /= Double.parseDouble(lcd.getText());
									break;
								case 11:
									opl *= Double.parseDouble(lcd.getText());
									break;
								case 12:
									opl -= Double.parseDouble(lcd.getText());
									break;
								case 13:
									opl += Double.parseDouble(lcd.getText());
									break;
							}
							lcd.setText(calcPattern.format(opl));
							clearText = true;

							if (i == 14)
								first = true;
							else
								lastOp = i;
						}
						break;
				}
			}
		}
	}

	public static void main(String args[]) {
		Calculator f = new Calculator();
		f.setTitle("Calculator Application");
		f.setBounds(200, 200, 300, 300);
		f.setVisible(true);

		Image icon = Toolkit.getDefaultToolkit().getImage("calcImage.gif");
		f.setIconImage(icon);
	}
}
