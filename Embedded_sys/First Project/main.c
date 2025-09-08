
# include <avr/io.h>
# include <util/delay.h>



# define LED_PIN PD6	// Example LED pin number

int main(void) {
    // set PD4 as output
    DDRD |= (1 << LED_PIN);

    while (1) {
        // turn the LED on
        PORTD |= (1 << LED_PIN);
        _delay_ms(500); // simple delay

        // turn the LED off
        PORTD &= ~(1 << LED_PIN);
        _delay_ms(500); // simple delay
    }

}
