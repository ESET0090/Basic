
# ifdef HAL_GPIO_H
# define HAL_GPIO_H


#include <avr/io.h>
#include "pin_config.h"

#define Input 0
#define Output 1


void HAL_GPIO_init(volatile uint8_t *port, uint8_t pin, uint8_t direction);
void HAL_GPIO_Write(volatile uint8_t *port, uint8_t pin, uint8_t value);
void HAL_GPIO_Toggle(volatile uint8_t *port, uint8_t pin);
void HAL_GPIO_Read(volatile uint8_t *port, uint8_t pin);

#endif 
