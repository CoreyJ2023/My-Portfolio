'''
Programmer:     Corey Jenkins
Date:           June 8, 2023
Filename:       latte_selection.py
Purpose:        A GUI made in Tkinter based on program that was done in C# and Visual Basic using Windows form. This program allows the user
                to select a latte. The button "Select Latte" will not be active until the user selects one. the exit button won't be selected until
                the user clicks Select Latte. Once the Select Latte button is clicked, the user cannot select a latte.
'''
# import Tkinter.
import tkinter as tk

# Window set-up.
window=tk.Tk()
window.title("Latte Selection")
window.geometry("1050x540")
window.resizable(width="true", height="true")
font_tuple1=("Tahoma", 16, "bold")

# Button configurations. 
def button_select_pumpkinspice():
    if btn_pumpkinspice["state"] == "normal":
        lbl_mocha["state"] = "disable"
        lbl_pumpkinspice["state"] = "active"
        btn_latteselect['state'] = "active"
        
def button_select_mocha():
    if btn_mocha["state"] == "normal":
        lbl_pumpkinspice["state"] = "disable"
        lbl_mocha["state"] = "active"
        btn_latteselect["state"] = "active"
        
def button_select_latte_select():
    if btn_latteselect["state"] == "normal":
        btn_pumpkinspice["state"] = "disable"
        btn_mocha["state"] = "disable"
        lbl_enjoy["state"] = "active"
        lbl_latte_select["state"] = "disable"
        btn_exit["state"] = "active"

def button_exit():
    window.destroy()
        
# Frame, labels and buttons set-up.
frm_latte = tk.Frame(window, relief=tk.RAISED, bd=1)
lbl_latte=tk.Label(window, text = "Latte Selection", font=font_tuple1)
img_pumpkinspice=tk.PhotoImage(file="pumpkin.png")
lbl_pumpkinspice=tk.Label(window, image=img_pumpkinspice, state="disabled")
img_mocha=tk.PhotoImage(file="mocha.png",)
lbl_mocha=tk.Label(window, image=img_mocha, state="disabled")
btn_pumpkinspice=tk.Button(window, text="Pumpkin Spice", bg="bisque", command=button_select_pumpkinspice)
btn_latteselect=tk.Button(window, text="Select latte", bg="bisque", state="disabled", command=button_select_latte_select)
btn_mocha=tk.Button(window, text="Mocha", bg="bisque", command=button_select_mocha)
lbl_latte_select=tk.Label(window, text="Choose a flavor and then click Select Latte button.")
btn_exit=tk.Button(window, text="Exit", bg="bisque", state="disabled", command=button_exit)
lbl_enjoy=tk.Label(window, text="Enjoy your latte!", state="disabled")

# GUI layout
lbl_latte.grid(row=1, column=3)
lbl_pumpkinspice.grid(row=2, column=2, padx=5, pady=5)
lbl_mocha.grid(row=2, column=4, padx=5, pady=5)
btn_pumpkinspice.grid(row=3, column=2, padx=5, pady=5)
btn_latteselect.grid(row=3, column=3, padx=5, pady=5,)
btn_mocha.grid(row=3, column=4, padx=5, pady=5)
lbl_latte_select.grid(row=4, column=3, sticky="nsew")
lbl_enjoy.grid(row=5, column=3, sticky="nsew", padx=5, pady=5)
btn_exit.grid(row=6, column=3)

# Finish the GUI.
window.mainloop()

