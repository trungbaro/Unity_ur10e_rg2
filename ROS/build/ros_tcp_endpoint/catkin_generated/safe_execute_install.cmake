execute_process(COMMAND "/home/bao/ur10e_gr2_ver3/ur10e_rg2_PickAndPlace/ROS/build/ros_tcp_endpoint/catkin_generated/python_distutils_install.sh" RESULT_VARIABLE res)

if(NOT res EQUAL 0)
  message(FATAL_ERROR "execute_process(/home/bao/ur10e_gr2_ver3/ur10e_rg2_PickAndPlace/ROS/build/ros_tcp_endpoint/catkin_generated/python_distutils_install.sh) returned error code ")
endif()
