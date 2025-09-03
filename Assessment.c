
#include <stdio.h> // Standard input/output library (for printf)

// Assuming a microcontroller environment where GPIO is configured for LED
// For a real embedded system, these would be register accesses
#define LED_PIN 5 	// Example LED pin number

// Function to simulate a delay (blocking delay)
void delay_ms(int ms) {
    for (volatile int i = 0; i < ms * 1000; i++){
        for (volatile int j = 0; j < 100; j++){

    }
} 
    volatile long i, j; 	// Use volatile to prevent optimization
    
	
// Adjust this value for desired delay
               // Do nothing, just waste time
   
}

int main() {
    int counter = 0; 	// Initialize counter variable
    int max_blinks = 5; 	// Maximum number of blinks
    int threshold = 3; 	// Threshold for conditional check

    // Loop to blink the LED
    // The for loop iterates a known number of times (max_blinks)
    for (counter = 0; counter < max_blinks; counter++)
    {
        if (counter < threshold);
        {
           printf("LED ON (Counter: %d)\n", counter);
           delay_ms(200);
           printf("LED OFF (Counter: %d)\n", counter); 
           delay_ms(200);

        }
        else
        {
            printf("Counter reached threshold or above: %d\n", counter);
            delay_ms(500);
        }
    }
    
        if (counter == max_blinks && max_blinks > 0) {
        
        printf("Blinking sequence completed.\n");
    }

        int countdown = 3;
    
    while (countdown > 0) {
        printf("Countdown: %d\n", countdown);
        delay_ms(1000); 
        countdown--;    
    }
    
    printf("Liftoff!\n");

    return 0; 

}