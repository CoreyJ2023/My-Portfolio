'''
Programmer:     Corey Jenkins
Date:           June 7, 2020 
Name:           SphereScriptScaleAnimation
Purpose:        To use Python to set up a keyframe/animation in which the Sphere will animate
                and scale. 
'''

# Note: The default cube must be deleted and Sphere must be added for this script to work.
# Import
import bpy
 
#The positions in which the object will move at these locations on 
# The X, Y, and Z axis.
location_positions = (0,3,2),(4,1,6),(3,-5,1),(3,10,1),(1,8,1)

# These are the coordinates on the axis in which the sphere will
# scale or increase in size.
scale_positions = (1,1,1),(2,2,2),(3,3,3),(4,4,4),(5,5,5)

# The starting position.
start_pos =(0,0,0)

# The object assigned to.
bpy.ops.mesh.primitive_uv_sphere_add(enter_editmode=False,)
ob = bpy.data.objects['Sphere']



#Starting point.
frame_num = 0

# Setup for the sphere to move along the five coordinates in the variable
# location_position. It will move fast at 20 frames per keyframe.
# 20, 40, 60 and 80.
for position in location_positions:
    bpy.context.scene.frame_set(frame_num)
    ob.location = position
    ob.keyframe_insert(data_path="location", index =-1)
    frame_num += 20 #The sphere will move to each location 20FPS.
    
 # Setup for the sphere to expand in size on all three axis under
 # the variable scale_positions.
 # At 60 frames per keyframe, the sphere will expand slowly. 
for position in scale_positions:
    bpy.context.scene.frame_set(frame_num)
    ob.scale = position 
    ob.keyframe_insert(data_path='scale', index =-1)
    frame_num += 60