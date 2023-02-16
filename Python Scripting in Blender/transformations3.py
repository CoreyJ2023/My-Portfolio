'''
Programmer:        Corey Jenkkins
Date:              February 20, 2022
Program Name:      Transformation3.py
Purpose:           A demonstration on multplying matrices to determine where the sphere will move on a set of coordinates.
'''

import bpy

def main():
    
    # These variables will give the product for the coordinates on the X, Y, and Z axis.
    # [(2 -1 0), (3 2 -1), (-3, 1, 2)] and [(1,4,3)] Multiply then add. Dot Product.
    # Set 1
    point_x = (2*1) + (-1*4) + (0*3)
    point_y = (3*1) + (2*4) + (-1*3)
    point_z = (-3*1) + (1*4) + (2*3)

    # This should have the sphere move to its next location.
    location_positions = (0,0,0),(point_x,point_y,point_z)
    # The object assigned to.
    bpy.ops.mesh.primitive_uv_sphere_add(enter_editmode=False,)
    ob = bpy.data.objects['Sphere']
    
    print("The solution is: [",point_x,point_y,point_z, "]")

    #Starting point on the frame timeline.
    frame_num = 0

    # Setup for the sphere to move along the five coordinates in the variable
    # location_position. It will move fast at 60 frames per keyframe.
    # 60, 120, and 180.
    for position in location_positions:
        bpy.context.scene.frame_set(frame_num)
        ob.location = position
        ob.keyframe_insert(data_path="location", index =-1)
        frame_num += 60 #The sphere will move to each location 60FPS.
        
main()
    
