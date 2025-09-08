
# include <avr/io.h>
# include <util/delay.h>



# define LED_PIN PD3
# define Button_PIN PD1	

int main(void) {
    // set PD4 as output
    DDRD |= (1 << LED_PIN);
    DDRD &= ~(1 << Button_PIN);
    PORTD |= (1 << Button_PIN);


    while (1) {
        if (!(PIND & (1 << Button_PIN))) {
            PORTD |= (1 << LED_PIN);
            _delay_ms(500);
            PORTD &= ~(1 << LED_PIN); // turn off LED
            _delay_ms(500);
 
        }
        else {
         PORTD &= ~(1 << LED_PIN); // turn off LED
        }
        
    }

}