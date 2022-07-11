## Production line simulator

The goal of this application, was to create the simulation of production line dispatcher. It was supposed to contains elements of diagnostics of the supervised production process" as well as self-diagnosis of the watchful operator
over the correct course of production.  
* The program includes a login window to log in to the production line simulator.
* The dispatcher can change the production paramters such as:
  - speed of the production line
  - active ventilators
* The application constantly checks the presence and "consciousness" of the operator. The self-diagnostic element consists message informing that the presence must be confirmed by pressing a confirm activity-button. If there is no confirmation after the timeout, ana alarm is triggered and the operator is logged out of the system. 
* Current production parameters and CPU usage are monitored. 
* The program randomly generates a failure. If the dispatcher does not follow the given instructions privided to fix the failure then  the dispatcher will be logged out of the system.  

<img src="https://github.com/ojanczewska/Production_line_simulator/blob/main/img/production.jpg" >  
<img src="https://github.com/ojanczewska/Production_line_simulator/blob/main/img/login.jpg">

