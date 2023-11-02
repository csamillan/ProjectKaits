import { useState, useEffect } from "react"
import { Button, CardBody, CardHeader, Col, Container, Row } from "reactstrap"
import TableOrder from "./Componentes/TablaOrder"
import ModalOrder from "./Componentes/ModalOrder"

const App = () => {

    const [order, setOrder] = useState([])
    const [mostrarModal, setMostrarModal] = useState(false);

    const mostrarOrder = async () => {

        const response = await fetch("api/orders/Get");

        if (response.ok) {
            const data = await response.json();
            setOrder(data);
        } else {
            console.log("error al listar");
        }
    }

    useEffect(() => {
        mostrarOrder()
    });

    const saveOrder = async (order) => {
        const response = await fetch("api/orders/Post", {
            method: 'POST',
            headers: {
                'Content-type': 'application/json; charset=utf-8'
            },
            body: JSON.stringify(order)
        });
        console.log(order);
        if (response.ok) {
            setMostrarModal(!mostrarModal)
            mostrarOrder()
        }
    }

    return (
        <Container>
            <Row className="mt-5">
                <Col sm="12">
                    <CardHeader>
                        <h5>
                            Lista de Ordenes
                        </h5>
                    </CardHeader>
                    <CardBody>
                        <Button size="sm" color="success" onClick={() => setMostrarModal(!mostrarModal) }> Agregar Nueva Orden</Button>
                        <hr></hr>
                        <TableOrder data={order}></TableOrder>
                    </CardBody>
                </Col>
            </Row>

            <ModalOrder mostrarModal={mostrarModal} setMostrarModal={setMostrarModal} saveOrder={saveOrder} />
        </Container>
    )
}

export default App;