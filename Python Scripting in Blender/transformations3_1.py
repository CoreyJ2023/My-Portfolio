'''
Programmer:        Corey Jenkins
Date:              February 20, 2022
Program Name:      Transformation3.py
Purpose:           A demonstration on multplying matrices to determine where the sphere will move on a set of coordinates with small modifcaitons. 
'''
import bpy

def main():
    sphere1()
    sphere2()

    for obj in bpy.data.objects:
        bpy.data.objects.remove(obj)
    
def sphere1():
    
    # Let's give [1 3] [-5 2] with [2 2] that being for X and Y
    point_x = (1*2) + (3*2)
    point_y = (-5*2) + (2*2)
        
    # This should have the sphere move to its next location.
    location_positions = (1,3,0),(-5,2,0),(point_x,point_y,0)

    # The object assigned to.
    bpy.ops.mesh.primitive_uv_sphere_add(enter_editmode=False,)
    ob = bpy.data.objects['Sphere']
    print("The solution is: [",point_x,point_y,"]")
         
    #Starting point on the frame timeline.
    frame_num = 0
         
    # Setup for the sphere to move along the five coordinates in the variable
    # location_position. It will move fast at 60 frames per keyframe.
    # 60 and 120
    for position in location_positions:
        bpy.context.scene.frame_set(frame_num)
        ob.location = position 
        ob.keyframe_insert(data_path="location", index =-1)
        frame_num += 60 #The sphere will move to each location 60FPS.
        
def sphere2():
    # try [2 -2][3 -2] with [5 5] to be used for X and Y
    point_x = (2 * 5) + (-2 * 5)
    point_y = (3 * 5) + (-2 * 5)
    # Let's give [1 3] [-5 2] with [2 2] that being for X and Y
        
    # This should have the sphere move to its next location.
    location_positions = (2,-2,0),(3,-2,0),(point_x,point_y,0)
    # The object assigned to.
    bpy.ops.mesh.primitive_uv_sphere_add(enter_editmode=False,)
    ob = bpy.data.objects['Sphere.001']
    print("The solution is: [",point_x,point_y,"]")
    #Starting point on the frame timeline.
    frame_num = 0
        
    for position in location_positions:
        bpy.context.scene.frame_set(frame_num)
        ob.location = position
        ob.keyframe_insert(data_path="location", index =-1)
        frame_num += 20 #The sphere will move to each location 20PF           
main()
    
